#include <BluetoothSerial.h>

#if !defined(CONFIG_BT_ENABLED) || !defined(CONFIG_BLUEDROID_ENABLED)
// #error Bluetooth is not enabled! Please run `make menuconfig` to and enable it
#endif
BluetoothSerial SerialBT;
int buttonstate_1 = 0;
int buttonstate_2 = 0;
int buttonstate_3 = 0;
// int PulseSensorPurplePin = 13;
String data;
String tempature;
int ThermistorPin = 4;
int Vo;
float R1 = 10000;
float logR2, R2, T;
float c1 = 1.009249522e-03, c2 = 2.378405444e-04, c3 = 2.019202697e-07;
void setup()
{
  pinMode(15, INPUT_PULLUP);
  pinMode(2, INPUT_PULLUP);
  pinMode(0, INPUT_PULLUP);
  Serial.begin(115200);
  SerialBT.begin("ESP32test"); // Bluetooth device name
  Serial.println("The device started, now you can pair it with bluetooth!");
}

void loop()
{
  button();
  data = "";
  if (Serial.available())
  {
    SerialBT.write(Serial.read());
  }
  if (SerialBT.available())
  {
    Serial.write(SerialBT.read());
  }
  delay(200);
  void Temp();
}
void button()
{
  buttonstate_1 = digitalRead(0);
  buttonstate_2 = digitalRead(2);
  buttonstate_3 = digitalRead(15);
  if (buttonstate_3 == LOW)
  {
    data += "Button_3";
    data += ", ";
    data += String(T);
    SerialBT.println(data);
    Serial.print(data);
  }
  if (buttonstate_2 == LOW)
  {
    data += "Button_2";
    data += ", ";
    data += String(T);
    SerialBT.println(data);
    Serial.print(data);
  }
  if (buttonstate_1 == LOW)
  {
    data += "Button_1";
    data += ", ";
    data += String(T);
    SerialBT.println(data);
    Serial.print(data);
  }
  else
  {
  }
  delay(1000);
}

void Temp()
{
  Vo = analogRead(ThermistorPin);
  R2 = R1 * (1023.0 / (float)Vo - 1.0);
  logR2 = log(R2);
  T = (1.0 / (c1 + c2 * logR2 + c3 * logR2 * logR2 * logR2));
  T = T - 273.15;
}
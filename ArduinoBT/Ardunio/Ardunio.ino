#include <BluetoothSerial.h>
#include <Adafruit_MPU6050.h>
#include <Adafruit_Sensor.h>
#include <Wire.h>

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
Adafruit_MPU6050 mpu;
void setup()
{
  pinMode(15, INPUT_PULLUP);
  pinMode(2, INPUT_PULLUP);
  pinMode(0, INPUT_PULLUP);
  Serial.begin(115200);
  SerialBT.begin("ESP32test"); // Bluetooth device name
  Serial.println("The device started, now you can pair it with bluetooth!");
  if (!mpu.begin())
  {
    Serial.println("Failed to find MPU6050 chip");
    while (1)
    {
      delay(10);
    }
    mpu.setAccelerometerRange(MPU6050_RANGE_8_G);
    mpu.setGyroRange(MPU6050_RANGE_500_DEG);
    mpu.setFilterBandwidth(MPU6050_BAND_5_HZ);
  }
}
void loop()
{
  data = "";
  button();
  if (Serial.available())
  {
    SerialBT.write(Serial.read());
  }
  if (SerialBT.available())
  {
    Serial.write(SerialBT.read());
  }
  sensors_event_t a, g, temp;
  mpu.getEvent(&a, &g, &temp);
  data = "";
  data += "Sensor";
  data += ", ";
  data += a.acceleration.x;
  data += ", ";
  data += a.acceleration.y;
  data += ", ";
  data += a.acceleration.z;
  data += ", ";
  data += g.gyro.x;
  data += ", ";
  data += g.gyro.y;
  data += ", ";
  data += g.gyro.z;
  data += ", ";
  data += temp.temperature;
  SerialBT.println(data);
  // Serial.print(data);
  delay(2000);
}
void button()
{
  buttonstate_1 = digitalRead(0);
  buttonstate_2 = digitalRead(2);
  buttonstate_3 = digitalRead(15);
  if (buttonstate_3 == LOW)
  {
    data = "";
    data += "Button_3";
    data += ", ";
    SerialBT.println(data);
    Serial.print(data);
    delay(2000);
  }
  if (buttonstate_2 == LOW)
  {
    data = "";
    data += "Button_2";
    data += ", ";
    SerialBT.println(data);
    Serial.print(data);
    delay(2000);
  }
  if (buttonstate_1 == LOW)
  {
    data = "";
    data += "Button_1";
    data += ", ";
    SerialBT.println(data);
    Serial.print(data);
    delay(2000);
  }
}
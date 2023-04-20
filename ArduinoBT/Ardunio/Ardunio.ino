#include <BluetoothSerial.h>
#if !defined(CONFIG_BT_ENABLED) || !defined(CONFIG_BLUEDROID_ENABLED)
//#error Bluetooth is not enabled! Please run `make menuconfig` to and enable it
#endif

BluetoothSerial SerialBT;
int buttonstate_1 = 0; 
int buttonstate_2 =  0; 
int buttonstate_3 = 0; 
void setup() {
  pinMode(15, INPUT_PULLUP);
  pinMode(2, INPUT_PULLUP);
  pinMode(0, INPUT_PULLUP);
  Serial.begin(115200);
  SerialBT.begin("ESP32test"); //Bluetooth device name
  Serial.println("The device started, now you can pair it with bluetooth!");
}

void loop() {
  button();
  if (Serial.available()) {
    SerialBT.write(Serial.read());
  }
  if (SerialBT.available()) {
    Serial.write(SerialBT.read());
  }
  delay(200);
  // SerialBT.println("123");
}
void button() {
buttonstate_1 = digitalRead(0);
buttonstate_2 = digitalRead(2);
buttonstate_3 = digitalRead(15);
if (buttonstate_3 == LOW){
  SerialBT.println("HIGH 0");
} 
if (buttonstate_2 == LOW){
  SerialBT.println("HIGH 2");
} 
if (buttonstate_1 == LOW){
  SerialBT.println("HIGH 15");
}else{
}
delay(1000);
}

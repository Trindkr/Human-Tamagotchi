import serial
import random 
from random import randint
def pulse():
     return randint(50,90)         
def write_to_file():
     with open("PythonSerialRead/testfile.txt", "w") as fp:
          fp.writelines(cc[2:][:-5]+"Pulse: "+str(pulse()))
          fp.close()
          return print(cc[2:][:-5]+"Pulse:"+str(pulse()))
ser = serial.Serial("COM6", 115200) #COM Port for reading 
while True:
     cc=str(ser.readline())
     write_to_file()

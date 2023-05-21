import serial
import random 
from random import randint
def pulse():
     return randint(50,90)         
def write_to_file():
     with open("testfile.txt", "w") as fp:
          if  "S" in cc[2]: 
               fp.write(cc[2:][:-5]) #cc[2:][:-5]
               print(cc[2])
               fp.close()
               return print(cc[2:][:-5])
          else:
               fp.write(cc[2:][:-5]+str(pulse()))
               print(cc[2])
               fp.close()
               return print(cc[2:][:-5])
ser = serial.Serial("COM6", 115200) #COM Port for reading 
while True:
     cc=str(ser.readline())
     write_to_file()

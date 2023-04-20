import serial
def write_to_file():
     with open("testfile.txt", "w") as fp:
          fp.writelines(cc[2:][:-5]+"\n" )
          fp.close()
          return 0
ser = serial.Serial("COM10", 115200) #COM Port for reading 
while True:
     cc=str(ser.readline())
     print(cc[2:][:-5])
     write_to_file()
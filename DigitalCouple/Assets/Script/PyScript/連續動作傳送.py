import socket
import time
HOST = 'localhost'
PORT = 5566

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.connect((HOST, PORT))
defl =[174.08,-174]
while True:
    increase = 1
    for i in range(30):
        for j in range(2):
            if(j%2):
                outdata = str(0)+" "+str(i)+" "+ "0"+" "+ str(defl[0])+"\n"
            else:
                outdata = str(1) + " " + str(-i) + " " + "0" + " " + str(defl[1]) + "\n"
            print('send: ' + outdata)
            s.send(outdata.encode())
            indata = s.recv(1024)
            if len(indata) == 0:  # connection closed
                s.close()
                print('server closed connection.')
                break
            print('recv: ' + indata.decode())
            time.sleep(0.01)
    for i in range(30,0,-1):
        for j in range(2):
            if(j%2):
                outdata = str(0)+" "+str(i)+" "+ "0"+" "+ str(defl[0])+"\n"
            else:
                outdata = str(1) + " " + str(-i) + " " + "0" + " " + str(defl[1]) + "\n"
            print('send: ' + outdata)
            s.send(outdata.encode())
            indata = s.recv(1024)
            if len(indata) == 0:  # connection closed
                s.close()
                print('server closed connection.')
                break
            print('recv: ' + indata.decode())
            time.sleep(0.01)


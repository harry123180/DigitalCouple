import socket
import time
HOST = 'localhost'
PORT = 5566

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.connect((HOST, PORT))
defl =[174.08,-174]
while True:
    increase = 1
    for i in range(0,30,2):
        for j in range(64):
            outdata = str(j)+" "+str(i)+" "+ str(777)+" "+ str(777)+"\n"
            print('send: ' + outdata)
            s.send(outdata.encode())
            indata = s.recv(1024)
            """
            if len(indata) == 0:  # connection closed
                s.close()
                print('server closed connection.')
                break
            print('recv: ' + indata.decode())
            """
            time.sleep(0.001)
    for i in range(30,0,-2):
        for j in range(64):
            outdata = str(j)+" "+str(i)+" "+ str(777)+" "+ str(777)+"\n"
            print('send: ' + outdata)
            s.send(outdata.encode())
            #indata = s.recv(1024)
            time.sleep(0.001)


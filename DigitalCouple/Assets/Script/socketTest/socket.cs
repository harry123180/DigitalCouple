using UnityEngine;
using System.Collections;
//引入庫
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class socket:MonoBehaviour
{
    
    //以下預設都是私有的成員
    Socket serverSocket; //伺服器端socket
    Socket clientSocket; //客戶端socket
    IPEndPoint ipEnd; //偵聽埠
    string recvStr; //接收的字串
    string sendStr; //傳送的字串
    float _agnle1;
    float _angle2;
    float _angle3;
    byte[] recvData=new byte[1024]; //接收的資料，必須為位元組
    byte[] sendData=new byte[1024]; //傳送的資料，必須為位元組
    int recvLen; //接收的資料長度
    Thread connectThread; //連線執行緒

    //初始化
    void InitSocket()
    {
        //定義偵聽埠,偵聽任何IP
        ipEnd=new IPEndPoint(IPAddress.Any,5566);
        //定義套接字型別,在主執行緒中定義
        serverSocket=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
        //連線
        serverSocket.Bind(ipEnd);
        //開始偵聽,最大10個連線
        serverSocket.Listen(10);

        
             
        //開啟一個執行緒連線，必須的，否則主執行緒卡死
        connectThread=new Thread(new ThreadStart(SocketReceive));
        connectThread.Start();
    }

    //連線
    void SocketConnet()
    {
        if(clientSocket!=null)
            clientSocket.Close();
        //控制檯輸出偵聽狀態
        print("Waiting for a client");
        //一旦接受連線，建立一個客戶端
        clientSocket=serverSocket.Accept();
        //獲取客戶端的IP和埠
        IPEndPoint ipEndClient=(IPEndPoint)clientSocket.RemoteEndPoint;
        //輸出客戶端的IP和埠
        print("Connect with "+ipEndClient.Address.ToString()+":"+ipEndClient.Port.ToString());
        //連線成功則傳送資料
        sendStr="Welcome to my server";
        SocketSend(sendStr);
    }

    void SocketSend(string sendStr)
    {
        //清空傳送快取
        sendData=new byte[1024];
        //資料型別轉換
        sendData=Encoding.ASCII.GetBytes(sendStr);
        //傳送
        clientSocket.Send(sendData,sendData.Length,SocketFlags.None);
    }
    void Dispatcher(float[] target_array,float[] reg_ref){
        /* 
        target_array 應傳入global.cs裡面管理的global array variable 
        並且是管理Joint degree array
        */
        for (int i =1;i<=3;i++){//根據當前通訊格式 第0值用來分類 後面3個值分別對應XYZ
            Debug.Log(i);
            if(reg_ref[i] != 777f ){
                target_array[i-1]=reg_ref[i];//把暫存器值賦予過去目標陣列
            }
            
        }
    }
    void classfilter(float[] reg_ref){//分類-並派送
        // 傳入暫存器 派送到全域變數
        //Debug.Log(reg_ref[3]);
    switch(reg_ref[0]){
        case 0:
            Dispatcher(global.LeftUpLeg,reg_ref);//編號0是LeftUpLeg
            break;
        case 1:
            Dispatcher(global.RightUpLeg,reg_ref);//編號0是RightUpLeg
            break;
        case 2:
            Dispatcher(global.Hips,reg_ref);//編號0是RightUpLeg
            break;
        case 3:
            Dispatcher(global.LeftLeg,reg_ref);//編號0是RightUpLeg
            break;
        case 4:
            Dispatcher(global.LeftFoot,reg_ref);//編號0是RightUpLeg
            break;
        case 5:
            Dispatcher(global.LeftToeBase,reg_ref);//編號0是RightUpLeg
            break;
        case 6:
            Dispatcher(global.LeftToe_End,reg_ref);//編號0是RightUpLeg
            break;
        case 7:
            Dispatcher(global.RightLeg,reg_ref);//編號0是RightUpLeg
            break;
        case 8:
            Dispatcher(global.RightFoot,reg_ref);//編號0是RightUpLeg
            break;
        case 9:
            Dispatcher(global.RightToeBase,reg_ref);//編號0是RightUpLeg
            break;
        case 10:
            Dispatcher(global.RightToe_End,reg_ref);//編號0是RightUpLeg
            break;
        case 11:
            Dispatcher(global.Spine,reg_ref);//編號0是RightUpLeg
            break;
        case 12:
            Dispatcher(global.Spine1,reg_ref);//編號0是RightUpLeg
            break;
        case 13:
            Dispatcher(global.Spine2,reg_ref);//編號0是RightUpLeg
            break;
        case 14:
            Dispatcher(global.LeftShoulder,reg_ref);//編號0是RightUpLeg
            break;
        case 15:
            Dispatcher(global.LeftArm,reg_ref);//編號0是RightUpLeg
            break;
        case 16:
            Dispatcher(global.LeftForeArm,reg_ref);//編號0是RightUpLeg
            break;
        case 17:
            Dispatcher(global.LeftHand,reg_ref);//編號0是RightUpLeg
            break;
        case 18:
            Dispatcher(global.LeftHandIndex1,reg_ref);//編號0是RightUpLeg
            break;
        case 19:
            Dispatcher(global.LeftHandIndex2,reg_ref);//編號0是RightUpLeg
            break;
        case 20:
            Dispatcher(global.LeftHandIndex3,reg_ref);//編號0是RightUpLeg
            break;
        case 21:
            Dispatcher(global.LeftHandIndex4,reg_ref);//編號0是RightUpLeg
            break;
        case 22:
            Dispatcher(global.LeftHandMiddle1,reg_ref);//編號0是RightUpLeg
            break;
        case 23:
            Dispatcher(global.LeftHandMiddle2,reg_ref);//編號0是RightUpLeg
            break;
        case 24:
            Dispatcher(global.LeftHandMiddle3,reg_ref);//編號0是RightUpLeg
            break;
        case 25:
            Dispatcher(global.LeftHandMiddle4,reg_ref);//編號0是RightUpLeg
            break;
        case 26:
            Dispatcher(global.LeftHandPinky1,reg_ref);//編號0是RightUpLeg
            break;
        case 27:
            Dispatcher(global.LeftHandPinky2,reg_ref);//編號0是RightUpLeg
            break;
        case 28:
            Dispatcher(global.LeftHandPinky3,reg_ref);//編號0是RightUpLeg
            break;
        case 29:
            Dispatcher(global.LeftHandPinky4,reg_ref);//編號0是RightUpLeg
            break;
        case 30:
            Dispatcher(global.LeftHandRing1,reg_ref);//編號0是RightUpLeg
            break;
        case 31:
            Dispatcher(global.LeftHandRing2,reg_ref);//編號0是RightUpLeg
            break;
        case 32:
            Dispatcher(global.LeftHandRing3,reg_ref);//編號0是RightUpLeg
            break;
        case 33:
            Dispatcher(global.LeftHandRing4,reg_ref);//編號0是RightUpLeg
            break;
        case 34:
            Dispatcher(global.LeftHandThumb1,reg_ref);//編號0是RightUpLeg
            break;
        case 35:
            Dispatcher(global.LeftHandThumb2,reg_ref);//編號0是RightUpLeg
            break;
        case 36:
            Dispatcher(global.LeftHandThumb3,reg_ref);//編號0是RightUpLeg
            break;
        case 37:
            Dispatcher(global.LeftHandThumb4,reg_ref);//編號0是RightUpLeg
            break;
        case 38:
            Dispatcher(global.Neck,reg_ref);//編號0是RightUpLeg
            break;
        case 39:
            Dispatcher(global.Head,reg_ref);//編號0是RightUpLeg
            break;
        case 40:
            Dispatcher(global.HeadTop_End,reg_ref);//編號0是RightUpLeg
            break;
        case 41:
            Dispatcher(global.RightShoulder,reg_ref);//編號0是RightUpLeg
            break;
        case 42:
            Dispatcher(global.RightArm,reg_ref);//編號0是RightUpLeg
            break;
        case 43:
            Dispatcher(global.RightForeArm,reg_ref);//編號0是RightUpLeg
            break;
        case 44:
            Dispatcher(global.RightHand,reg_ref);//編號0是RightUpLeg
            break;
        case 45:
            Dispatcher(global.RightHandIndex1,reg_ref);//編號0是RightUpLeg
            break;
        case 46:
            Dispatcher(global.RightHandIndex2,reg_ref);//編號0是RightUpLeg
            break;
        case 47:
            Dispatcher(global.RightHandIndex3,reg_ref);//編號0是RightUpLeg
            break;
        case 48:
            Dispatcher(global.RightHandIndex4,reg_ref);//編號0是RightUpLeg
            break;
        case 49:
            Dispatcher(global.RightHandMiddle1,reg_ref);//編號0是RightUpLeg
            break;
        case 50:
            Dispatcher(global.RightHandMiddle2,reg_ref);//編號0是RightUpLeg
            break;
        case 51:
            Dispatcher(global.RightHandMiddle3,reg_ref);//編號0是RightUpLeg
            break;
        case 52:
            Dispatcher(global.RightHandMiddle4,reg_ref);//編號0是RightUpLeg
            break;
        case 53:
            Dispatcher(global.RightHandPinky1,reg_ref);//編號0是RightUpLeg
            break;
        case 54:
            Dispatcher(global.RightHandPinky2,reg_ref);
            break;
        case 55:
            Dispatcher(global.RightHandPinky3,reg_ref);
            break;
        case 56:
            Dispatcher(global.RightHandPinky4,reg_ref);
            break;
        case 57:
            Dispatcher(global.RightHandRing1,reg_ref);
            break;
        case 58:
            Dispatcher(global.RightHandRing2,reg_ref);
            break;
        case 59:
            Dispatcher(global.RightHandRing3,reg_ref);
            break;
        case 60:
            Dispatcher(global.RightHandRing4,reg_ref);
            break;
        case 61:
            Dispatcher(global.RightThumb1,reg_ref);
            break;
        case 62:
            Dispatcher(global.RightThumb2,reg_ref);
            break;
        case 63:
            Dispatcher(global.RightThumb3,reg_ref);
            break;
        case 64:
            Dispatcher(global.RightThumb4,reg_ref);
            break;












            
                
        default:
                Debug.Log("Default case");
                break;
    }

    }
    //伺服器接收
    void SocketReceive()
    {
        //連線
        SocketConnet();      
        //進入接收迴圈
        while(true)
        {
            //對data清零
            recvData=new byte[1024];
            //獲取收到的資料的長度
            recvLen=clientSocket.Receive(recvData);
            //如果收到的資料長度為0，則重連並進入下一個迴圈
            if(recvLen==0)
            {
                SocketConnet();
                continue;
            }
            //輸出接收到的資料
            recvStr=Encoding.ASCII.GetString(recvData,0,recvLen);
            Debug.Log("data = " +recvStr);
            
            string[] words = recvStr.Split(' ');//收到數據 先分割 EX: 0 0 0 0 代表 type 0 joint_type=[0,0,0]
            float[] reg = new float[4];//暫存器
            int i =0;
            foreach (var word in words)
            {
                reg[i] = float.Parse(word);
                i++;
            }
            classfilter(reg);
            /*
            //把暫存器的角度值同步入全域變數
            global._angle1 = reg[0];
            global._angle2 = reg[1];
            global._angle3 = reg[2];
            */
    
            global.recvStr = recvStr;
            //print(recvStr);
            //將接收到的資料經過處理再發送出去
            sendStr="From Server: "+recvStr;
            //SocketSend(sendStr);
        }
    }

    //連線關閉
    void SocketQuit()
    {
        //先關閉客戶端
        if(clientSocket!=null)
            clientSocket.Close();
        //再關閉執行緒
        if(connectThread!=null)
        {
            connectThread.Interrupt();
            connectThread.Abort();
        }
        //最後關閉伺服器
        serverSocket.Close();
        print("diconnect");
    }

    // Use this for initialization
    void Start()
    {
        recvStr = global.recvStr;
        InitSocket(); //在這裡初始化server
    }


    // Update is called once per frame
    void Update()
    {
//..
    }

    void OnApplicationQuit()
    {
        SocketQuit();
    }
}
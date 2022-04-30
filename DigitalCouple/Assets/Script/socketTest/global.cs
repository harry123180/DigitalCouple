using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//管理全域變數
static class global 
{
// 關於關節變數定義
//存放在關節定義.md
public static string recvStr;
public static float _angle1;
public static float _angle2;
public static float _angle3;
public static float[] LeftUpLeg = new float[3]{-0.576f,0.051f,174.08f}; //number 0 
public static float[] RightUpLeg = new float[3]{1.395f,-0.008f,-178.699f};//number 1
public static float[] Hips = new float[3]{0.0f,0.0f,0.0f};//number 2
public static float[] LeftLeg = new float[3]{-8.14f,4.595f,2.962f};//number 3
public static float[] LeftFoot = new float[3]{61.638f,-17.636f,-0.88f};//number 4
public static float[] LeftToeBase = new float[3]{28.936f,-5.744f,0.0f};//number 5
public static float[] LeftToe_End = new float[3]{0.0f,0.0f,0.0f};//number 6
public static float[] RightLeg = new float[3]{-1.0f,0.101f,-2.747f};//number 7
public static float[] RightFoot = new float[3]{61.87f,6.41f,0.0f};//number 8
public static float[] RightToeBase = new float[3]{29.2f,6.47f,0.0f};//number 9
public static float[] RightToe_End = new float[3]{0.0f,0.0f,0.0f};//number 10
public static float[] Spine = new float[3]{-6.123f,0.0f,-0.0f};//number 11
public static float[] Spine1 = new float[3]{0.0f,0.0f,0.0f};//number 12
public static float[] Spine2 = new float[3]{0.0f,0.0f,0.0f};//number 13
public static float[] LeftShoulder = new float[3]{106.35f,-92.39f,-3.9f};//number 14
public static float[] LeftArm = new float[3]{-15.6f,0.384f,-1.877f};//number 15
public static float[] LeftForeArm = new float[3]{0.0f,0.529f,0.0f};//number 16
public static float[] LeftHand = new float[3]{0.31f,-8.259f,8.126f};//number 17
public static float[] LeftHandIndex1 = new float[3]{-0.298f,0.147f,-8.099f};//number 18
public static float[] LeftHandIndex2 = new float[3]{0.0f,0.0f,0.0f};//number 19
public static float[] LeftHandIndex3 = new float[3]{0.0f,0.0f,0.0f};//number 20
public static float[] LeftHandIndex4 = new float[3]{0.0f,0.0f,0.0f};//number 21
public static float[] LeftHandMiddle1 = new float[3]{-0.324f,-0.036f,-7.94f};//number 22
public static float[] LeftHandMiddle2 = new float[3]{0.0f,0.0f,0.0f};//number 23
public static float[] LeftHandMiddle3 = new float[3]{0.0f,0.0f,0.0f};//number 24
public static float[] LeftHandMiddle4 = new float[3]{0.0f,0.0f,0.0f};//number 25
public static float[] LeftHandPinky1 = new float[3]{-0.351f,-0.224f,-8.124f};//number 26
public static float[] LeftHandPinky2 = new float[3]{0.0f,0.0f,0.0f};//number 27
public static float[] LeftHandPinky3 = new float[3]{0.0f,0.0f,0.0f};//number 28
public static float[] LeftHandPinky4 = new float[3]{0.0f,0.0f,0.0f};//number 29
public static float[] LeftHandRing1 = new float[3]{-0.305f,0.099f,-8.099f};//number 30
public static float[] LeftHandRing2 = new float[3]{0.0f,0.0f,0.0f};//number 31
public static float[] LeftHandRing3 = new float[3]{0.0f,0.0f,0.0f};//number 32
public static float[] LeftHandRing4 = new float[3]{0.0f,0.0f,0.0f};//number 33
public static float[] LeftHandThumb1 = new float[3]{20.58f,-15.94f,-36.7f};//number 34
public static float[] LeftHandThumb2 = new float[3]{0.0f,-0.099f,-4.63f};//number 35
public static float[] LeftHandThumb3 = new float[3]{0.0f,0.6f,-8.4f};//number 36
public static float[] LeftHandThumb4 = new float[3]{0.0f,0.0f,0.0f};//number 37
public static float[] Neck = new float[3]{6.123f,0.0f,0.0f};//number 38
public static float[] Head = new float[3]{0.0f,0.0f,0.0f};//number 39
public static float[] HeadTop_End = new float[3]{0.0f,0.0f,0.0f};//number 40
public static float[] RightShoulder = new float[3]{105.6f,92.8f,1.05f};//number 41
public static float[] RightArm = new float[3]{-15.63f,-0.38f,1.93f};//number 42
public static float[] RightForeArm = new float[3]{0.0f,-0.427f,0.0f};//number 43
public static float[] RightHand = new float[3]{1.51f,8.56f,-7.981f};//number 44
public static float[] RightHandIndex1 = new float[3]{-1.477f,-0.38f,7.89f};//number 45
public static float[] RightHandIndex2 = new float[3]{0.0f,0.0f,0.0f};//number 46
public static float[] RightHandIndex3 = new float[3]{0.0f,0.0f,0.0f};//number 47
public static float[] RightHandIndex4 = new float[3]{0.0f,0.0f,0.0f};//number 48
public static float[] RightHandMiddle1 = new float[3]{-1.486f,-0.318f,7.953f};//number 49
public static float[] RightHandMiddle2 = new float[3]{0.0f,0.0f,0.0f};//number 50
public static float[] RightHandMiddle3 = new float[3]{0.0f,0.0f,0.0f};//number 51
public static float[] RightHandMiddle4 = new float[3]{0.0f,0.0f,0.0f};//number 52
public static float[] RightHandPinky1 = new float[3]{-1.56f,0.28f,7.939f};//number 53
public static float[] RightHandPinky2 = new float[3]{0.0f,0.0f,0.0f};//number 54
public static float[] RightHandPinky3 = new float[3]{0.0f,0.0f,0.0f};//number 55
public static float[] RightHandPinky4 = new float[3]{0.0f,0.0f,0.0f};//number 56
public static float[] RightHandRing1 = new float[3]{-1.49f,-0.266f,7.90f};//number 57
public static float[] RightHandRing2 = new float[3]{0.0f,0.0f,0.0f};//number 58
public static float[] RightHandRing3 = new float[3]{0.0f,0.0f,0.0f};//number 59
public static float[] RightHandRing4 = new float[3]{0.0f,0.0f,0.0f};//number 60
public static float[] RightThumb1 = new float[3]{19.826f,14.864f,36.296f};//number 61
public static float[] RightThumb2 = new float[3]{0.0f,0.0f,4.81f};//number 62
public static float[] RightThumb3 = new float[3]{0.0f,0.0f,8.921f};//number 63
public static float[] RightThumb4 = new float[3]{0.0f,0.0f,0.0f};//number 64




}

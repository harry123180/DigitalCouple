using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [Range(-180.0f, 180.0f)]
    public float _angle1;
    [Range(-180.0f, 180.0f)]
    public float _angle2;
    [Range(-180.0f, 180.0f)]
    public float _angle3;
    public Joint_OBJ LeftUpLeg_OBJ ;// 將該關節的屬性綁定至該物件
    public Joint_OBJ RightUpLeg_OBJ ;
    public Joint_OBJ Hips_OBJ ;
    public Joint_OBJ LeftLeg_OBJ ;
    public Joint_OBJ LeftFoot_OBJ ;
    public Joint_OBJ LeftToeBase_OBJ ;
    public Joint_OBJ LeftToe_End_OBJ ;
    public Joint_OBJ RightLeg_OBJ ;
    public Joint_OBJ RightFoot_OBJ ;
    public Joint_OBJ RightToeBase_OBJ ;
    public Joint_OBJ RightToe_End_OBJ ;
    public Joint_OBJ Spine_OBJ ;
    public Joint_OBJ Spine1_OBJ ;
    public Joint_OBJ Spine2_OBJ ;
    public Joint_OBJ LeftShoulder_OBJ ;
    public Joint_OBJ LeftArm_OBJ ;
    public Joint_OBJ LeftForeArm_OBJ ;
    public Joint_OBJ LeftHand_OBJ ;
    public Joint_OBJ LeftHandIndex1_OBJ ;
    public Joint_OBJ LeftHandIndex2_OBJ ;
    public Joint_OBJ LeftHandIndex3_OBJ ;
    public Joint_OBJ LeftHandIndex4_OBJ ;
    public Joint_OBJ LeftHandMiddle1_OBJ ;
    public Joint_OBJ LeftHandMiddle2_OBJ ;
    public Joint_OBJ LeftHandMiddle3_OBJ ;
    public Joint_OBJ LeftHandMiddle4_OBJ ;
    public Joint_OBJ LeftHandPinky1_OBJ ;
    public Joint_OBJ LeftHandPinky2_OBJ ;
    public Joint_OBJ LeftHandPinky3_OBJ ;
    public Joint_OBJ LeftHandPinky4_OBJ ;
    public Joint_OBJ LeftHandRing1_OBJ ;
    public Joint_OBJ LeftHandRing2_OBJ ;
    public Joint_OBJ LeftHandRing3_OBJ ;
    public Joint_OBJ LeftHandRing4_OBJ ;
    public Joint_OBJ LeftHandThumb1_OBJ ;
    public Joint_OBJ LeftHandThumb2_OBJ ;
    public Joint_OBJ LeftHandThumb3_OBJ ;
    public Joint_OBJ LeftHandThumb4_OBJ ;
    public Joint_OBJ Neck_OBJ ;
    public Joint_OBJ Head_OBJ ;
    public Joint_OBJ HeadTop_End_OBJ ;
    public Joint_OBJ RightShoulder_OBJ ;
    public Joint_OBJ RightArm_OBJ ;
    public Joint_OBJ RightForeArm_OBJ ;
    public Joint_OBJ RightHand_OBJ ;
    public Joint_OBJ RightHandIndex1_OBJ ;
    public Joint_OBJ RightHandIndex2_OBJ ;
    public Joint_OBJ RightHandIndex3_OBJ ;
    public Joint_OBJ RightHandIndex4_OBJ ;
    public Joint_OBJ RightHandMiddle1_OBJ ;
    public Joint_OBJ RightHandMiddle2_OBJ ;
    public Joint_OBJ RightHandMiddle3_OBJ ;
    public Joint_OBJ RightHandMiddle4_OBJ ;
    public Joint_OBJ RightHandPinky1_OBJ ;
    public Joint_OBJ RightHandPinky2_OBJ ;
    public Joint_OBJ RightHandPinky3_OBJ ;
    public Joint_OBJ RightHandPinky4_OBJ ;
    public Joint_OBJ RightHandRing1_OBJ ;
    public Joint_OBJ RightHandRing2_OBJ ;
    public Joint_OBJ RightHandRing3_OBJ ;
    public Joint_OBJ RightHandRing4_OBJ ;
    public Joint_OBJ RightThumb1_OBJ ;
    public Joint_OBJ RightThumb2_OBJ ;
    public Joint_OBJ RightThumb3_OBJ ;
    public Joint_OBJ RightThumb4_OBJ ;
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        LeftUpLeg_OBJ.Rotate(global.LeftUpLeg);//傳入角度值至該關節
        RightUpLeg_OBJ.Rotate(global.RightUpLeg);
        Hips_OBJ.Rotate(global.Hips);
        LeftLeg_OBJ.Rotate(global.LeftLeg);
        LeftFoot_OBJ.Rotate(global.LeftFoot);
        LeftToeBase_OBJ.Rotate(global.LeftToeBase);
        LeftToe_End_OBJ.Rotate(global.LeftToe_End);
        RightLeg_OBJ.Rotate(global.RightLeg);
        RightFoot_OBJ.Rotate(global.RightFoot);
        RightToeBase_OBJ.Rotate(global.RightToeBase);
        RightToe_End_OBJ.Rotate(global.RightToe_End);
        Spine_OBJ.Rotate(global.Spine);
        Spine1_OBJ.Rotate(global.Spine1);
        Spine2_OBJ.Rotate(global.Spine2);
        LeftShoulder_OBJ.Rotate(global.LeftShoulder);
        LeftArm_OBJ.Rotate(global.LeftArm);
        LeftForeArm_OBJ.Rotate(global.LeftForeArm);
        LeftHand_OBJ.Rotate(global.LeftHand);
        LeftHandIndex1_OBJ.Rotate(global.LeftHandIndex1);
        LeftHandIndex2_OBJ.Rotate(global.LeftHandIndex2);
        LeftHandIndex3_OBJ.Rotate(global.LeftHandIndex3);
        LeftHandIndex4_OBJ.Rotate(global.LeftHandIndex4);
        LeftHandMiddle1_OBJ.Rotate(global.LeftHandMiddle1);
        LeftHandMiddle2_OBJ.Rotate(global.LeftHandMiddle2);
        LeftHandMiddle3_OBJ.Rotate(global.LeftHandMiddle3);
        LeftHandMiddle4_OBJ.Rotate(global.LeftHandMiddle4);
        LeftHandPinky1_OBJ.Rotate(global.LeftHandPinky1);
        LeftHandPinky2_OBJ.Rotate(global.LeftHandPinky2);
        LeftHandPinky3_OBJ.Rotate(global.LeftHandPinky3);
        LeftHandPinky4_OBJ.Rotate(global.LeftHandPinky4);
        LeftHandRing1_OBJ.Rotate(global.LeftHandRing1);
        LeftHandRing2_OBJ.Rotate(global.LeftHandRing2);
        LeftHandRing3_OBJ.Rotate(global.LeftHandRing3);
        LeftHandRing4_OBJ.Rotate(global.LeftHandRing4);
        LeftHandThumb1_OBJ.Rotate(global.LeftHandThumb1);
        LeftHandThumb2_OBJ.Rotate(global.LeftHandThumb2);
        LeftHandThumb3_OBJ.Rotate(global.LeftHandThumb3);
        LeftHandThumb4_OBJ.Rotate(global.LeftHandThumb4);
        Neck_OBJ.Rotate(global.Neck);
        Head_OBJ.Rotate(global.Head);
        HeadTop_End_OBJ.Rotate(global.HeadTop_End);
        RightShoulder_OBJ.Rotate(global.RightShoulder);
        RightArm_OBJ.Rotate(global.RightArm);
        RightForeArm_OBJ.Rotate(global.RightForeArm);
        RightHand_OBJ.Rotate(global.RightHand);
        RightHandIndex1_OBJ.Rotate(global.RightHandIndex1);
        RightHandIndex2_OBJ.Rotate(global.RightHandIndex2);
        RightHandIndex3_OBJ.Rotate(global.RightHandIndex3);
        RightHandIndex4_OBJ.Rotate(global.RightHandIndex4);
        RightHandMiddle1_OBJ.Rotate(global.RightHandMiddle1);
        RightHandMiddle2_OBJ.Rotate(global.RightHandMiddle2);
        RightHandMiddle3_OBJ.Rotate(global.RightHandMiddle3);
        RightHandMiddle4_OBJ.Rotate(global.RightHandMiddle4);
        RightHandPinky1_OBJ.Rotate(global.RightHandPinky1);
        RightHandPinky2_OBJ.Rotate(global.RightHandPinky2);
        RightHandPinky3_OBJ.Rotate(global.RightHandPinky3);
        RightHandPinky4_OBJ.Rotate(global.RightHandPinky4);
        RightHandRing1_OBJ.Rotate(global.RightHandRing1);
        RightHandRing2_OBJ.Rotate(global.RightHandRing2);
        RightHandRing3_OBJ.Rotate(global.RightHandRing3);
        RightHandRing4_OBJ.Rotate(global.RightHandRing4);
        RightThumb1_OBJ.Rotate(global.RightThumb1);
        RightThumb2_OBJ.Rotate(global.RightThumb2);
        RightThumb3_OBJ.Rotate(global.RightThumb3);
        RightThumb4_OBJ.Rotate(global.RightThumb4);






    }
}

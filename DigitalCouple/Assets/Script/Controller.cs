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
    public Joint_OBJ RightUpLeg_OBJ ;// 將該關節的屬性綁定至該物件
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        LeftUpLeg_OBJ.Rotate(global.LeftUpLeg);//傳入角度值至該關節
        RightUpLeg_OBJ.Rotate(global.RightUpLeg);


    }
}

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
    public Jointt j ;// 將該關節的屬性綁定至該物件
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        j.Rotate(_angle1,_angle2,_angle3);//傳入角度值至該關節
        _angle1 = global._angle1;//更新glbal Variable
        _angle2 = global._angle1;//更新glbal Variable
        _angle3 = global._angle1;//更新glbal Variable

    }
}

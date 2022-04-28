using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jointt : MonoBehaviour
{

 //public transform Init_rotation;
 

public void Rotate(float arr_0 ,float arr_1,float arr_2)
{
        //transform.Rotate(Vector3.right * _angle); // Rotate X Axis
        transform.localRotation = Quaternion.Euler(arr_0, arr_1, arr_2);

    
    }
public void get_position(){
    print(transform.localPosition[1]);
    
}

}



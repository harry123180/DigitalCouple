using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joint_OBJ : MonoBehaviour
{
public void Rotate(float[] arr)
{
        //transform.Rotate(Vector3.right * _angle); // Rotate X Axis
        transform.localRotation = Quaternion.Euler(arr[0], arr[1], arr[2]);

    
    }
public void get_position(){
    print(transform.localPosition[1]);
    
}
}

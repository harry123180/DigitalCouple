using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class Joint_Controller : MonoBehaviour
{
    public Transform transform_;
    //[Header( "Safe Frame" )]
    [Range( -50f, 50f )]
    public float SafeFrameTop =5.0f;
    [Range( -50f, 50f )]
    public float SafeFrameTopB =5.0f;
    
    
    // Start is called before the first frame update
    void  Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //transform_.Rotate(Vector3.up  * 0.05f);
        
        
        //transform_.rotation = Quaternion.Euler
        transform_.rotation = Quaternion.Euler(0.0f,SafeFrameTop,SafeFrameTopB);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopController : MonoBehaviour
{
    public float Speed = 5;

    void Start()
    {
        
    }

    void Update()
    {
        if(TimelineControl.state == 3)
        {
            WorldTime.Time += ( Input.GetAxis("Horizontal") * Speed * Time.deltaTime / 90f ) * 0.25f;
            Debug.Log(WorldTime.Time);
            transform.Rotate(new Vector3(0, 0, -Input.GetAxis("Horizontal") * Speed * Time.deltaTime));
        }        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{

    SliderJoint2D handsUp;
    JointMotor2D motor;

    public float handSpeed;

    // Start is called before the first frame update
    void Start()
    {
        handsUp = GetComponent<SliderJoint2D>();
        motor = handsUp.motor;
        //motor.motorSpeed = handSpeed;
        //handsUp.motor = motor;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            motor.motorSpeed = -10;
            handsUp.motor = motor;
        } 
        
        
        else
        {
            motor.motorSpeed = 5;
            handsUp.motor = motor;
        }
        
    }
}

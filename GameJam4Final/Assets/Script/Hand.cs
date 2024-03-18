using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{

    SliderJoint2D handsUp;
    JointMotor2D motor;
    public GameObject entrance;

    public float handSpeed;

    // Start is called before the first frame update
    void Start()
    {
        handsUp = GetComponent<SliderJoint2D>();
        motor = handsUp.motor;
        entrance.SetActive(true);
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
            entrance.SetActive(false);
        } 
        
        
        else
        {
            motor.motorSpeed = 5;
            handsUp.motor = motor;
            entrance.SetActive(true);
        }
        
    }
}

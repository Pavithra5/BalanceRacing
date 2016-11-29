using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class CarController : MonoBehaviour {

    public float speed = 1500f;
    public float rotationSpeed = 15f;
    private float movement = 0;
    public WheelJoint2D backWheel;
    public WheelJoint2D frontWheel;
    private float rotation = 0f;
    public Rigidbody2D rb;

    //Called every frame
    void Update()
    {
        movement=-Input.GetAxisRaw("Vertical")*speed;
        rotation = Input.GetAxisRaw("Horizontal") * rotationSpeed;
    }

    //Called on a constant time
    void FixedUpdate()
    {
        if(movement==0)
        {
            backWheel.useMotor = false;
            frontWheel.useMotor = false;
        }
        else
        {
            backWheel.useMotor = true;
            frontWheel.useMotor = true;
            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000 };
            backWheel.motor = motor;
            frontWheel.motor = motor;
        }
        rb.AddTorque(-rotation * Time.fixedDeltaTime);
    }
}

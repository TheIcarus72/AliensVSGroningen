using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public float Rotation;
    public int movementspeed = 20;
    //public float Acceleration = 1;
    public float acceleration;
    public float maxSpeed;
    private float setSpeed;
    public bool isMoving = false;
    public bool isReversing = false;
    private bool forward = false;
    private bool backward = false;

    // Use this for initialization
    void Start()
    {
        setSpeed = acceleration;
        
    }

    // Update is called once per frame
    void Update()
    {

   
        

        if (Input.GetButton("Up"))
        {
            //determines forward movement
            isMoving = true;
            forward = true;
            backward = false;
            transform.Translate(Vector3.forward * Time.deltaTime * acceleration);
            if (acceleration < maxSpeed)
            {
                acceleration += 0.5f;
            }
            
        } else
        {
            isMoving = false;
        }
        if (isMoving == false && forward == true)
        {
            //slow down the acceleration so that the ship can move in the opposite direction 
            transform.Translate(Vector3.forward * Time.deltaTime * acceleration);
            if (acceleration > 0)
            {
                acceleration -= 1;
            }

            if (acceleration != 0)
            {
                if (Input.GetButton("Left"))
                {
                    transform.Rotate(0.0f * Time.deltaTime, -Rotation * Time.deltaTime, 0.0f * Time.deltaTime);
                }
                if (Input.GetButton("Right"))
                {
                    transform.Rotate(0.0f * Time.deltaTime, Rotation * Time.deltaTime, 0.0f * Time.deltaTime);
                }
            }

        }

        if (Input.GetButton("Down"))
        {
            //backward movement
            isReversing = true;
            backward = true;
            forward = false;
            transform.Translate(Vector3.forward * Time.deltaTime * acceleration);
            if (acceleration > -maxSpeed)
            {
                acceleration -= 0.5f;
            }

        }
        else
        {
            isReversing = false;
        }
        if (isReversing == false && backward == true)
        {
            //slow down the acceleration so that the car can move in the opposite direction 
            transform.Translate(Vector3.forward * Time.deltaTime * acceleration);

            if (acceleration < 0)
            {
                acceleration += 1;
            }
        }
        
        if (acceleration != 0)
        {
            if (forward == true)
            {
                if (Input.GetButton("Left"))
                {
                    transform.Rotate(0.0f * Time.deltaTime, -Rotation * Time.deltaTime, 0.0f * Time.deltaTime);
                }
                if (Input.GetButton("Right"))
                {
                    transform.Rotate(0.0f * Time.deltaTime, Rotation * Time.deltaTime, 0.0f * Time.deltaTime);
                }
            }
            if (backward == true)
            {
                if (Input.GetButton("Right"))
                {
                    transform.Rotate(0.0f * Time.deltaTime, -Rotation * Time.deltaTime, 0.0f * Time.deltaTime);
                }
                if (Input.GetButton("Left"))
                {
                    transform.Rotate(0.0f * Time.deltaTime, Rotation * Time.deltaTime, 0.0f * Time.deltaTime);
                }
            }
        }

    }

}
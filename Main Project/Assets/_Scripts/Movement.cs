//______________________________________________________________//
//___SCRIPT_EXPLANATION_________________________________________//
//______________________________________________________________//

// script which controlls the movement of the ship

//______________________________________________________________//
using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public float Rotation;
    public float acceleration;
	public float speed;
    public float maxSpeed;

    public bool isMoving = false;
    public bool isReversing = false;
    public bool forward = false;
    public bool backward = false;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
			if (speed > 0)
			{
				forward = true;
				backward = false;
			}
			else if (speed == 0)
			{
				forward = false;
				backward = false;
			}
			else if(speed < 0)
			{
				forward = false;
				backward = true;
			}
			if(isMoving == false && isReversing == false)
			{
				if(speed < 0.02 && speed > -0.02)
				{
					speed = speed/2;
				}
				if(speed < 0.0001 && speed > -0.0001)
				{
					speed = 0;
				}
			}
			
			if (Input.GetButton("Up") && ReplaceBuilding.selectingBuilding == false)
	        {
	            //determines forward movement
	            isMoving = true;
				transform.Translate(Vector3.forward * Time.deltaTime * speed * acceleration);
				if (speed < maxSpeed)
	            {
					speed += 0.5f *Time.deltaTime;
	            }
	            
	        } else
	        {
	            isMoving = false;
	        }
	        if (isMoving == false && forward == true)
	        {
				//slow down the speed so that the ship can move in the opposite direction 
				transform.Translate(Vector3.forward * Time.deltaTime * speed * acceleration);
				if (speed > 0.02)
	            {
					speed -= 1 * Time.deltaTime;
	            }

	        }

			if (Input.GetButton("Down") && ReplaceBuilding.selectingBuilding == false)
	        {
	            //backward movement
	            isReversing = true;
				transform.Translate(Vector3.forward * Time.deltaTime * speed * acceleration);
				if (speed > -maxSpeed)
	            {
					speed -= 0.5f * Time.deltaTime;
	            }

	        }
	        else
	        {
	            isReversing = false;
	        }

	        if (isReversing == false && backward == true)
	        {
				//slow down the speed so that the car can move in the opposite direction 
				transform.Translate(Vector3.forward * Time.deltaTime * speed * acceleration);

				if (speed < -0.02)
	            {
					speed += 1 * Time.deltaTime;
	            }
	        }
	        
			if (speed != 0)
	        {
				if (forward == true && speed < 1)
	            {
					if (Input.GetButton("Left") && ReplaceBuilding.selectingBuilding == false)
	                {
	                    transform.Rotate(0.0f, -Rotation * Time.deltaTime * speed, 0.0f);
	                }
					if (Input.GetButton("Right") && ReplaceBuilding.selectingBuilding == false)
	                {
	                    transform.Rotate(0.0f, Rotation * Time.deltaTime * speed, 0.0f);
	                }
				} else if (forward == true)
				{
					if (Input.GetButton("Left") && ReplaceBuilding.selectingBuilding == false)
					{
						transform.Rotate(0.0f, -Rotation * Time.deltaTime, 0.0f);
					}
					if (Input.GetButton("Right") && ReplaceBuilding.selectingBuilding == false)
					{
						transform.Rotate(0.0f, Rotation * Time.deltaTime, 0.0f);
					}
				}
				if (backward == true && speed > -1)
	            {
					if (Input.GetButton("Right")  && ReplaceBuilding.selectingBuilding == false)
	                {
	                    transform.Rotate(0.0f, -Rotation * Time.deltaTime * speed, 0.0f);
	                }
					if (Input.GetButton("Left") && ReplaceBuilding.selectingBuilding == false)
	                {
	                    transform.Rotate(0.0f, Rotation * Time.deltaTime * speed, 0.0f);
	                }
	            }
				else if (backward == true)
				{
					if (Input.GetButton("Right") && ReplaceBuilding.selectingBuilding == false)
					{
						transform.Rotate(0.0f, -Rotation * Time.deltaTime, 0.0f);
					}
					if (Input.GetButton("Left") && ReplaceBuilding.selectingBuilding == false)
					{
						transform.Rotate(0.0f, Rotation * Time.deltaTime, 0.0f);
					}
				}
	        }
			if (Input.GetButton("Up") && Input.GetButton("Down") && ReplaceBuilding.selectingBuilding == false)
			{
				isReversing = false;
				isMoving = false;
			}
	    }
}
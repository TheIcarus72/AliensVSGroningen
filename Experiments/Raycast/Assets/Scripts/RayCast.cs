using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void FixedUpdate () {
		Debug.DrawRay(Camera.main.transform.position,Camera.main.transform.TransformDirection(Vector3.forward));
		Vector3 fwd = Camera.main.transform.TransformDirection(Vector3.forward);

		if (Physics.Raycast(Camera.main.transform.position, fwd, 500)){
			print("There is something in front of the camera!");
		}
		else
		{
			print("Move along people, nothing to see here!");
		}
	}
}

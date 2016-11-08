using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void FixedUpdate () {
		RaycastHit hit;
		Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5f, 0));
		if(Physics.Raycast(ray, out hit))
		{
			Debug.Log(hit.collider.tag);
		}
		else
		{
			Debug.Log("Move along people, nothing to see here!");
		}
	}
}


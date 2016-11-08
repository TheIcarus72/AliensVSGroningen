using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour {
	static public GameObject target;
	// Use this for initialization
	void Start () {
		
	}
	
	void FixedUpdate () {
		RaycastHit hit;
		Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5f, 0));
		if(Physics.Raycast(ray, out hit))
		{
			if(ReplaceBuilding.selectingBuilding == false)
			{
				target = hit.collider.gameObject;
				Debug.Log (target);
				//Debug.Log(hit.collider.gameObject.tag);
			}
		}
		else
		{
			//Debug.Log("Move along people, nothing to see here!");
		}
	}
}

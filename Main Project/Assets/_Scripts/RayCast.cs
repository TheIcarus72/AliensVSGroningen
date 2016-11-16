//______________________________________________________________//
//___SCRIPT_EXPLANATION_________________________________________//
//______________________________________________________________//

// continiously checks for the first collision the raycast makes
// this is used in conjunction with the ReplaceBuilding script to check for replace-able buildings

//______________________________________________________________//
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

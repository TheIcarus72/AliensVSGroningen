//______________________________________________________________//
//___SCRIPT_EXPLANATION_________________________________________//
//______________________________________________________________//

// script that checks for collision with replace-able buildings and then rescales the replace-able building to the proper size
// (which is set on the collider objects on which this script is attached) (see Scalers/... in the hierarchy)

//______________________________________________________________//
using UnityEngine;
using System.Collections;

public class Scale : MonoBehaviour {
	public float scaleX = 1.0f;
	public float scaleY = 1.0f;
	public float scaleZ = 1.0f;

	public Scalers scalers;
	public bool scaled = false;
	void OnTriggerEnter(Collider col)
	{
		//Debug.Log(col.gameObject.tag);
		if(col.gameObject.tag == "Building")
		{
			if (col.gameObject.name == "Turbines" || col.gameObject.name == "Parking_Lot" || col.gameObject.name == "Shopping_Mall") {
				col.gameObject.transform.localScale = new Vector3 (scaleX,scaleY,scaleZ);
				scaled = true;
			}
		}
		if (col.gameObject.tag == "Plot") {
			scaled = true;
		}
	}
}

//______________________________________________________________//
//___SCRIPT_EXPLANATION_________________________________________//
//______________________________________________________________//

//this script checks the status of all the Scale script instances and then hides them
//this was needed to get the RayCast to not collide with the Scale colliders as this interfered with colliding with the actual replace-able buildings...

//______________________________________________________________//
using UnityEngine;
using System.Collections;

public class Scalers : MonoBehaviour {

	bool scalersDisabled = false;
	bool unscaled = false;
	// Use this for initialization
	void Start () {
		
	}

	void Update () {
		if(scalersDisabled == false)
		{
			foreach (Transform child in transform)
			{
				if(child.GetComponent<Scale>().scaled == false)
				{
					unscaled = true;
					//Debug.Log("this instance is not ready");
				}
				else
				{
					//Debug.Log("this instance is ready");
				}
			}
			if (unscaled == false) {
				DisableScalers();
			}
			unscaled = false;
		}
	}

	public void DisableScalers () {
		
		foreach (Transform child in transform)
		{
			child.gameObject.SetActive(false);
		}
		scalersDisabled = true;
	}
	public void EnableScalers () {

		foreach (Transform child in transform)
		{
			child.GetComponent<Scale>().scaled = false;
			child.gameObject.SetActive(true);
		}
		scalersDisabled = false;
		//Debug.Log("scalers enabled");
	}
}

using UnityEngine;
using System.Collections;

public class ReplaceBuilding : MonoBehaviour {
	static public bool selectingBuilding = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Space") && RayCast.target.tag == "Building")
		{
			selectingBuilding = true;
			Debug.Log("selecting building");
		}
	}
}

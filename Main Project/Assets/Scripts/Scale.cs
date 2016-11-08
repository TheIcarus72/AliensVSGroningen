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
			if (col.gameObject.name == "Factory" || col.gameObject.name == "Restaurant" || col.gameObject.name == "Supermarket") {
				col.gameObject.transform.localScale = new Vector3 ((scaleX * 3),(scaleY * 3),(scaleZ * 3));
				scaled = true;
			}
		}
		if (col.gameObject.tag == "Plot") {
			scaled = true;
		}
	}
}

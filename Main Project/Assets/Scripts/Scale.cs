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
			col.gameObject.transform.localScale = new Vector3(scaleX,scaleY,scaleZ);
			scaled = true;
		}
	}
}

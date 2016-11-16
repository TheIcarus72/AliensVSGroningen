using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {
	public int Rotation;
	// Use this for initialization
	void Start () {
	Rotation = 20;
	}
	
	// Update is called once per frame
	void Update () {
		 transform.Rotate(Vector3.up, Rotation * Time.deltaTime);
	}
}

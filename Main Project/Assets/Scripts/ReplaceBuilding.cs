using UnityEngine;
using System.Collections;

public class ReplaceBuilding : MonoBehaviour {
	static public bool selectingBuilding = false;
	public GameObject menu;
	public GameObject boxButton;
	public GameObject capsuleButton;
	public GameObject ballButton;
	public GameObject box;
	public GameObject capsule;
	public GameObject ball;
	public Scalers scalers;

	// Use this for initialization
	void Start () {
		menu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(RayCast.target != null)
		{
			if(Input.GetButtonDown("Space") && RayCast.target.tag == "Building")
			{
				selectingBuilding = true;
				menu.SetActive(true);
				if(RayCast.target.name == "Cube")
				{
					boxButton.SetActive(false);
					capsuleButton.SetActive(true);
					ballButton.SetActive(true);
				} else if (RayCast.target.name == "Capsule")
				{
					boxButton.SetActive(true);
					capsuleButton.SetActive(false);
					ballButton.SetActive(true);
				} else if (RayCast.target.name == "Sphere")
				{
					boxButton.SetActive(true);
					capsuleButton.SetActive(true);
					ballButton.SetActive(false);
				}
			}
		}
	}
	public void makeBox()
	{
		Vector3 buildingPos = RayCast.target.transform.position;
		Destroy(RayCast.target);
		GameObject boxSpawn = (GameObject)Instantiate(box,buildingPos,Quaternion.identity);
		boxSpawn.name = "Cube";
		selectingBuilding = false;
		menu.SetActive(false);
		scalers.EnableScalers();

	}
	public void makeCapsule()
	{
		Vector3 buildingPos = RayCast.target.transform.position;
		Destroy(RayCast.target);
		GameObject capsuleSpawn = (GameObject)Instantiate(capsule,buildingPos,Quaternion.identity);
		capsuleSpawn.name = "Capsule";
		selectingBuilding = false;
		menu.SetActive(false);
		scalers.EnableScalers();
	}
	public void makeBall()
	{
		Vector3 buildingPos = RayCast.target.transform.position;
		Destroy(RayCast.target);
		GameObject ballSpawn = (GameObject)Instantiate(ball,buildingPos,Quaternion.identity);
		ballSpawn.name = "Sphere";
		selectingBuilding = false;
		menu.SetActive(false);
		scalers.EnableScalers();
	}
}

//______________________________________________________________//
//___SCRIPT_EXPLANATION_________________________________________//
//______________________________________________________________//

// this script checks for replace-able buildings on the center of the camera (through the raycast)
// if the player then hits space it will open up the menu based on which building the camera was facing
// makeTurbines(), makeParkingLot(), makeShoppingMall(), don't get activated through this script but instead through the UI buttons with onClick() functions

//______________________________________________________________//
using UnityEngine;
using System.Collections;

public class ReplaceBuilding : MonoBehaviour {
	static public bool selectingBuilding = false;
	public GameObject menu;
	public GameObject UI3D;
	public GameObject turbinesButton;
	public GameObject parkinglotButton;
	public GameObject shoppingmallButton;
	public GameObject turbines;
	public GameObject parkinglot;
	public GameObject shoppingmall;
	public Scalers scalers;

	// Use this for initialization
	void Start () {
		menu.SetActive(false);
		UI3D.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(RayCast.target != null)
		{
			if(Input.GetButtonDown("Space"))
			{
				if (RayCast.target.tag == "Plot" || RayCast.target.tag == "Building") {
					selectingBuilding = true;
					menu.SetActive (true);
					UI3D.SetActive(true);
					if (RayCast.target.name == "Turbines") {
						turbinesButton.SetActive (false);
						parkinglotButton.SetActive (true);
						shoppingmallButton.SetActive (true);
					} else if (RayCast.target.name == "Parking_Lot") {
						turbinesButton.SetActive (true);
						parkinglotButton.SetActive (false);
						shoppingmallButton.SetActive (true);
					} else if (RayCast.target.name == "Shopping_Mall") {
						turbinesButton.SetActive (true);
						parkinglotButton.SetActive (true);
						shoppingmallButton.SetActive (false);
					} else {
						turbinesButton.SetActive (true);
						parkinglotButton.SetActive (true);
						shoppingmallButton.SetActive (true);
					}
				}
			}
		}
	}
	public void makeTurbines()
	{
		Vector3 buildingPos = RayCast.target.transform.position;
		Destroy(RayCast.target);
		GameObject factorySpawn = (GameObject)Instantiate(turbines,buildingPos,RayCast.target.transform.rotation);
		factorySpawn.name = "Turbines";
		selectingBuilding = false;
		menu.SetActive(false);
		UI3D.SetActive(false);
		scalers.EnableScalers();

	}
	public void makeParkingLot()
	{
		Vector3 buildingPos = RayCast.target.transform.position;
		Destroy(RayCast.target);
		GameObject restaurantSpawn = (GameObject)Instantiate(parkinglot,buildingPos,RayCast.target.transform.rotation);
		restaurantSpawn.name = "Parking_Lot";
		selectingBuilding = false;
		menu.SetActive(false);
		UI3D.SetActive(false);
		scalers.EnableScalers();
	}
	public void makeShoppingMall()
	{
		Vector3 buildingPos = RayCast.target.transform.position;
		Destroy(RayCast.target);
		GameObject supermarketSpawn = (GameObject)Instantiate(shoppingmall,buildingPos,RayCast.target.transform.rotation);
		supermarketSpawn.name = "Shopping_Mall";
		selectingBuilding = false;
		menu.SetActive(false);
		UI3D.SetActive(false);
		scalers.EnableScalers();
	}
}

using UnityEngine;
using System.Collections;

public class ReplaceBuilding : MonoBehaviour {
	static public bool selectingBuilding = false;
	public GameObject menu;
	public GameObject factoryButton;
	public GameObject restaurantButton;
	public GameObject supermarketButton;
	public GameObject factory;
	public GameObject restaurant;
	public GameObject supermarket;
	public Scalers scalers;

	// Use this for initialization
	void Start () {
		menu.SetActive(false);
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
					if (RayCast.target.name == "Factory") {
						factoryButton.SetActive (false);
						restaurantButton.SetActive (true);
						supermarketButton.SetActive (true);
					} else if (RayCast.target.name == "Restaurant") {
						factoryButton.SetActive (true);
						restaurantButton.SetActive (false);
						supermarketButton.SetActive (true);
					} else if (RayCast.target.name == "Supermarket") {
						factoryButton.SetActive (true);
						restaurantButton.SetActive (true);
						supermarketButton.SetActive (false);
					} else {
						factoryButton.SetActive (true);
						restaurantButton.SetActive (true);
						supermarketButton.SetActive (true);
					}
				}
			}
		}
	}
	public void makeFactory()
	{
		Vector3 buildingPos = RayCast.target.transform.position;
		Destroy(RayCast.target);
		GameObject factorySpawn = (GameObject)Instantiate(factory,buildingPos,RayCast.target.transform.rotation);
		factorySpawn.name = "Factory";
		selectingBuilding = false;
		menu.SetActive(false);
		scalers.EnableScalers();

	}
	public void makeRestaurant()
	{
		Vector3 buildingPos = RayCast.target.transform.position;
		Destroy(RayCast.target);
		GameObject restaurantSpawn = (GameObject)Instantiate(restaurant,buildingPos,RayCast.target.transform.rotation);
		restaurantSpawn.name = "Restaurant";
		selectingBuilding = false;
		menu.SetActive(false);
		scalers.EnableScalers();
	}
	public void makeSupermarket()
	{
		Vector3 buildingPos = RayCast.target.transform.position;
		Destroy(RayCast.target);
		GameObject supermarketSpawn = (GameObject)Instantiate(supermarket,buildingPos,RayCast.target.transform.rotation);
		supermarketSpawn.name = "Supermarket";
		selectingBuilding = false;
		menu.SetActive(false);
		scalers.EnableScalers();
	}
}

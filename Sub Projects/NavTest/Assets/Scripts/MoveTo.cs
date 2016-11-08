// MoveTo.cs
using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {

	public Transform goal;
	public float timer = 0.0f;
	private bool timerOn = false;
	private NavMeshAgent agent;

	void Start () {
		agent = GetComponent<NavMeshAgent>();
		agent.destination = goal.position; 
	}

	void Update() {
		if (timerOn && timer < 4) {
			timer += 1 * Time.deltaTime;
		}
		if (timer >= 4) {
			timerOn = false;
			timer = 0.0f;
			agent.Resume();
		}
	}
		void OnTriggerEnter (Collider other){
			if (other.gameObject.tag == "Trafficlight") {
				agent.Stop ();
				timerOn = true;
			}
	}


}
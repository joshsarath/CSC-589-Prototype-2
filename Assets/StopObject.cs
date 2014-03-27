using UnityEngine;
using System.Collections;

public class StopObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){

		PlayerMovement movement = GameObject.Find ("Player").GetComponent<PlayerMovement> ();
		Debug.Log(movement.transform.position);
		Debug.Log ("HIT!!");
		//movement.transform.position = movement.transform.position + new Vector3 (0, 0, -1);
		movement.transform.position= new Vector3(-900,-490,-250); 
		Debug.Log(movement.transform.position);
	}
}

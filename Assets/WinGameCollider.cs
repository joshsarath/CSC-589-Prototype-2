using UnityEngine;
using System.Collections;

public class WinGameCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		//PlayerMovement movement = (PlayerMovement)other.gameObject.GetComponent("PlayerMovement");
		if (other.name == "PlayerCube") {
			GameObject.Find ("Main Camera").GetComponent<GUILabels>().playerwins=true;	
			Destroy(GameObject.Find("PlayerCube"), 1);
		}
	}
}

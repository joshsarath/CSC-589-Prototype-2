using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed= -1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up")) {
			transform.position= transform.position + new Vector3(speed, 0, 0); 		
		}
		if (Input.GetKey ("left")) {
			transform.position= transform.position + new Vector3(0, 0, -1); 		
		}
		if (Input.GetKey ("right")) {
			transform.position= transform.position + new Vector3(0, 0, 1); 		
		}
		if (Input.GetKey ("down")) {
			transform.position= transform.position + new Vector3(1, 0, 0); 		
		}
	}
}

using UnityEngine;
using System.Collections;

public class ObstableMovement2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("left")) {
			if (transform.position.z <29){
				transform.position= transform.position + new Vector3(0, 0, 1); 	
			}
		}
		if (Input.GetKey ("right")) {
			if (transform.position.z >-47){
				transform.position= transform.position + new Vector3(0, 0, -1); 		
			}
		}
		if (Input.GetKey ("up")) {
			if (transform.position.x >-260){
				transform.position= transform.position + new Vector3(-1, 0, 0); 
			}
		}
		if (Input.GetKey ("down")) {
			if (transform.position.x <-39){
				transform.position= transform.position + new Vector3(1, 0, 0); 
			}
		}
	}
}

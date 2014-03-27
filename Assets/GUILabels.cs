using UnityEngine;
using System.Collections;

public class GUILabels : MonoBehaviour {

	public bool playerwins=false;
	public GUIStyle style;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		if (!playerwins) {
			GUI.Label (new Rect(0,0,400,200), ("Keep Going"), style);
		}
		else {
			GUI.Label (new Rect(0,0,400,200), ("You Win"), style);
		}
	}

}

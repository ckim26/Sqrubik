using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
        {
        if (Input.GetKeyDown(KeyCode.R)) //UserInput Taste R
        {
            gameObject.renderer.material.color = Color.red; 
        }
        if (Input.GetKeyDown(KeyCode.G)) ///UserInput Taste G
        {
            gameObject.renderer.material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B)) //UserInput Taste B
        {
            gameObject.renderer.material.color = Color.blue;
        }
	}
}

using UnityEngine;
using System.Collections;

public class Destroy2 : MonoBehaviour {
    string GameObject = "block";

	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (gameObject.tag == "block")
        {
            Destroy(gameObject);
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}

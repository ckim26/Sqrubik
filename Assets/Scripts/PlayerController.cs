using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 10.0f;

	float xAxis;
	float yAxis;
	float xposition = 240;      // Maximale bewegung auf der x Achse (Positiv)
	float yposition = 398;	// Maximale bewegung auf der y Achse	(Positiv)
	float xnposition = -239;  //maximale bewegung auf der x Achse (Negativ)	
	float ynposition = 12;    // Maximale bewegung auf der y Achse (Negativ)




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		xAxis = Input.GetAxis ("Horizontal");
		yAxis = Input.GetAxis ("Vertical");

		transform.Translate (new Vector3 (xAxis, yAxis, 0.0f) * speed);

		if (transform.position.x > xposition)
        {
			transform.position = new Vector3(xposition, transform.position.y, transform.position.z);
		}

		if (transform.position.x < xnposition)
        {
			transform.position = new Vector3(xnposition, transform.position.y, transform.position.z);
		}

		if (transform.position.y > yposition)
        {
			transform.position = new Vector3(transform.position.x, yposition, transform.position.z);
		}
		
		if (transform.position.y < ynposition)
        {
            transform.position = new Vector3(transform.position.x, ynposition, transform.position.z);
		}

		/*
		if (xposition > transform.position.x && xnposition < transform.position.x)   
		{   			
			xAxis = Input.GetAxis ("Horizontal");
			yAxis = Input.GetAxis ("Vertical");

				
			if ( yposition > transform.position.y && ynposition < transform.position.y)
			{
		//xAxis = Input.GetAxis ("Horizontal");
			// yAxis = Input.GetAxis ("Vertical");

			transform.Translate (new Vector3 (xAxis, yAxis, 0.0f) * speed);

			Debug.Log(transform.position.x);

			}
		}*/
	}
}

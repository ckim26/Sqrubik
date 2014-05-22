using UnityEngine;
using System.Collections;

public class BallOut : MonoBehaviour 
    
{   
    public Transform ball; //Auswahl des Objektes (??)
    public int Leben = 5;   // Anzahl de Leben
    void OnCollisionEnter(Collision collision) //Funktion für collision. (??) 
    {
        //Debug.Log(collision.gameObject.name);        //In der console den Namen des Balls anzeigen. (Nicht unbedingt notwedig)

        if (collision.gameObject.name == "newBall")  //Vergleicht ob der Ball mit dem Namen "newBall" mit der Wand colidiert, falls ja....
        {
            print("Ballig");
            Ball.ballig = false;  /*Setzen der Variable "ballig" auf false vom Script Ball, welche zuvor auf true gesetzt wurde, 
                                   um wieder einen Ball spawnen zu können. */

            Destroy(collision.gameObject); //Zerstört den Ball sobald er auf die Wand "BallOut" trifft.

            --Leben;
            if (Leben < 0)
            {
                Application.LoadLevel("Highscore");
            }
        }
     }

    void OnGUI()
    {

        GUI.Box(new Rect(Screen.width * 0.67f, 30, 100, 25), "Bälle übrig: " + Leben);
    }
      
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

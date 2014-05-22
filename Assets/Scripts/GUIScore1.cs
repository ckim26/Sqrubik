using UnityEngine;
using System.Collections;

public class GUIScore1 : MonoBehaviour {
    //int i = 100;
    public GUIText textCountdown;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width * 0.21f, 45, 100, 25), "Punkte: 0 " /*Später: + Anzahl der Punkte -Variable anlegen!!*/);   // x und y vom Startpunkt dann Breite und höhe in pixeln
        GUI.Box(new Rect(Screen.width * 0.21f, 15, 100, 25), "Zeit: 00:00:00");
        //GUI.Box(new Rect(Screen.width * 0.67f, 30, 100, 25), "Bälle: " +  Leben);
    }
}

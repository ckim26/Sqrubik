using UnityEngine;
using System.Collections;

public class GUIMenu : MonoBehaviour {

    public AudioClip beepS;
    private float timerS = 0.0f;  //Start
    bool loadGameS = false;   //Start
    bool timerActiveS = false;  //Start

    public AudioClip beepB;
    private float timerB = 0.0f;  // Beenden
    bool loadGameB = false;   //Beenden
    bool timerActiveB = false;  //Beenden

    public AudioClip beepO;
    private float timerO = 0.0f;  //Optionen
    bool loadGameO = false;   //Optionen
    bool timerActiveO = false;  //Optionen

    public AudioClip beepC;
    private float timerC = 0.0f;  //Credits
    bool loadGameC = false;   //Credits
    bool timerActiveC = false;  //Credits

    public AudioClip beepH;
    private float timerH = 0.0f;  //Highscore
    bool loadGameH = false;   //Highscore
    bool timerActiveH = false;  //Hghscore
    



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (timerActiveS)           //Start mit Ton
        {
            timerS += Time.deltaTime;
        }
        if (timerS >= 0.4f)
        {
            Application.LoadLevel("Game1");
        }


        if (timerActiveO)           //Optionen mit Ton
        {
            timerO += Time.deltaTime;
        }
        if (timerO >= 0.4f)
        {
            Application.LoadLevel("Optionen");
        }

        if (timerActiveH)           //Highscore mit Ton
        {
            timerH += Time.deltaTime;
        }
        if (timerH >= 0.4f)
        {
            Application.LoadLevel("Highscore");
        }


        if (timerActiveC)           //Credits mit Ton
        {
            timerC += Time.deltaTime;
        }
        if (timerC >= 0.4f)
        {
            Application.LoadLevel("Credits");
        }

        if (timerActiveB)          //Beenden mit Ton
        {
            timerB += Time.deltaTime;
        }
        if (timerB >= 0.5f)
        {
            Application.Quit();
        }
	
	}

    void OnGUI()
    {


        if (GUI.Button(new Rect(Screen.width * 0.47f, 150, 100, 50), "Start"))  // x und y vom Startpunkt dann Breite und höhe in pixeln
        {
            audio.PlayOneShot(beepS);
            timerActiveS = true;
            //Application.LoadLevel("Game1");
        }
        if (GUI.Button(new Rect(Screen.width * 0.67f, 325, 100, 50), "Optionen"))
        {
            audio.PlayOneShot(beepO);
            timerActiveO = true;
        }

        if (GUI.Button(new Rect(Screen.width * 0.47f, 325, 100, 50), "Highscore"))
        {
            audio.PlayOneShot(beepH);
            timerActiveH = true;
        }


        if (GUI.Button(new Rect(Screen.width * 0.27f, 325, 100, 50), "Credits"))
        {
            audio.PlayOneShot(beepC);
            timerActiveC = true;
        }
        if (GUI.Button(new Rect(Screen.width * 0.47f, 500, 100, 50), "Beenden"))
        {
            audio.PlayOneShot(beepB);
            timerActiveB = true;
            //Application.Quit();
        }
               
       
    }
}

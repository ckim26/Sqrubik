using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public int ballspeed = 10;          /*Hier wird die Geschwindigkeit des Balls zum Initialisiet, gilt aber nur einmal. 
                                        Wenn man den Wert in der Unity Engine ändert dann gilt immer dieser neue Wert. */
    private float timerStartGame = 0.0f;   // Spiel ohne Leertaste starten
    bool loadGameStartGame = false;
    bool timerActiveStartGame = false;

    public GameObject spawn;
    public static bool ballig = false;      //"Ball In Game", Variable die im Speicher gespeichert wird und man immer darauf zugreifen kann. (static)

    //public GameObject ball_prefab;

    private GameObject ball = null;         /*Hier wird eine neue variable angelegt, außerhald des if bereichs und wird auf "Null" gesetzt. 
                                            Null bedeutet "leer", weil GameObject keine variable ist sondern eine klasse, der man nicht "0" zuweisen kann. */
              
    //private int i = 0; [Beispiel für Zuweisung]

    public void Dying()
    {
        print("Dying");
        Destroy(this.gameObject);
        ballig = false;
    }

    // Use this for initialization
    void Start()
    {
        //rigidbody.AddForce(Vector3.forward * 500);
        timerActiveStartGame = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (timerActiveStartGame)           
        {

            timerStartGame += Time.deltaTime;
        }  // Soll machen das es nach einer bestimmten Zeit automatisch abgefeuert wird ähnlich wie bei der musik
        
        if (timerStartGame >= 5.0f && ballig == false) /*Falls die taste "BallStart" (in diesem fall mit Leertaste definiert), gedrückt wird und
                                                                   die Variable "ballig" gleich "false" ist dann....*/
        {
            print("Instantiate");
            ball = (GameObject)Instantiate(gameObject, spawn.transform.position, spawn.transform.rotation); /*"ball" wird eine mit einer neuen Funktion initialisiert.
                                                                                                                Ball wird im Spawn-Punkt gespawnt. */

            ball.name = "newBall";      //Name des neuen Balls


            //ball.rigidbody.AddRelativeForce(transform.forward * ballspeed, ForceMode.Impulse);  //Wird festgelegt in welche richtung und mit welcher Geschwindigkeit
            //ball.rigidbody.AddRelativeForce(Vector3.forward*2000);                                  //der Ball startet. 


            ball.rigidbody.velocity = Vector3.forward;   /*Wir wollen: x=0 y=0 z=1 Vector3(x, y, z) -> new Vector3(0, 0, 1) = Vector3.forward  
                                                                        [Vector3.right(1,0,0) / Vector3.Up(0,1,0] */

            //ball.AddComponent<BallSpeed>();

            ballig = true;      //ballig wird auf true gesetzt und bleibt auf true solange der ball im Game ist.
        }
        
        rigidbody.velocity = rigidbody.velocity.normalized * ballspeed; /* Die Geschwindigkeit des Balls wird normalisiert (auf 1 gesetzt) 
                                                                            und mit der aktuellen eingestellten Geschwindigkeit des Balls 8ballspeed) multipliziert.*/
    }

}

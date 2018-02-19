using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateau : MonoBehaviour {

    
    public GameObject Tableau;

    public static void Init()
    {
        //initialisation du plateau
        
    }

    public void Victory(bool vict)
    {
        //Envoie du signal de victoire

    }

	// Use this for initialization
	void Start () {
        var mur1 = new Bloc();
        mur1.transform.position = new Vector3(10, 0.1f, 10);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bloc : MonoBehaviour {

    public static int BLOC_VIDE = 1;
    public static int BLOC_CASSABLE = 2;
    public static int BLOC_INCASSABLE = 3;

    public GameObject bloc;
    protected int type;



	void Start() {
	  
	}
	
	// Update is called once per frame
	void Update() {
		
	}
}

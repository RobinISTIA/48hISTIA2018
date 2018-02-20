using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bloc : MonoBehaviour {

    public static int BLOC_VIDE = 0;
    public static int BLOC_CASSABLE = 1;
    public static int BLOC_INCASSABLE = 2;

    public GameObject bloc;
    protected int type;


	// Use this for initialization
	void Start() {
	    	
	}
	
	// Update is called once per frame
	void Update() {
		
	}
}

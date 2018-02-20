using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

    public int PosX { get; set; }
    public int PosY { get; set; }
    public int Range { get; set; }
    public Plateau plateau;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Detonate()
    {
        plateau.Explosion();
    }
}

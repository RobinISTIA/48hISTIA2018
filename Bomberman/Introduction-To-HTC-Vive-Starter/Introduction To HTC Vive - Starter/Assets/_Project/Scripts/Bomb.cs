using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

    public int Id { get; set; }
    public int PosX { get; set; }
    public int PosY { get; set; }
    public int Range { get; set; }
    public Plateau plateau;

    public Bomb()
    {

    }

    public Bomb(int id, int posX, int posY, int range)
    {
        Id = id;
        PosX = posX;
        PosY = posY;
        Range = range;
        Invoke("Detonate", 5);
    }

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Detonate()
    {
        plateau.Explosion(this);
    }
}

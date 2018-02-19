using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour {

    private const int INTERVALLE_DEPART_ROBOT = 5;
    private const int COUNTDOWN_START = 60;
    private GameObject[] lesSpawns;

    private bool isGameActive = false;

    private int currentCountdown = 60;
    
	// Use this for initialization
	void Start () {
        isGameActive = true
        lesSpawns = GameObject.FindGameObjectsWithTag("Spawner");
        currentCountdown = COUNTDOWN_START;

        
	}
	
	// Update is called once per frame
	void Update () {
        currentCountdown -= (int)Time.deltaTime;

        if (currentCountdown >= 0)
        {
            isGameActive = false;
            Debug.Log("Victory");
        }
    }
}

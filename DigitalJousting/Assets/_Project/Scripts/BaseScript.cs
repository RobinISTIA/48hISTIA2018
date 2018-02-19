using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScript : MonoBehaviour {

    private Transform parent;
    private Transform spawn;

    private AudioSource audioPlayer;
    private ParticleSystem particlesSyst;

    public GameObject robot;
    // Use this for initialization
    void Start () {
        spawn = GetComponentInChildren<Transform>();
        parent = GetComponent<Transform>();
        audioPlayer = GetComponent<AudioSource>();
        particlesSyst = GetComponentInChildren<ParticleSystem>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void instanciateNewRobot()
    {
        Instantiate(robot, spawn.position, parent.rotation);
        particlesSyst.Play();
        audioPlayer.Play();
    }
}

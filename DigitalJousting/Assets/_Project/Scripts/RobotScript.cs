using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotScript : MonoBehaviour {

    public GameObject robotObject;

    private Transform robotPosition;
    private SkinnedMeshRenderer[] robotRenderer;
    private bool robotIsAlive = true;
    private AudioSource audioPlayer;
    private ParticleSystem particles;
	// Use this for initialization
	void Start () {
        robotObject = GetComponent<GameObject>();
        robotPosition = GetComponent<Transform>();
        audioPlayer = GetComponent<AudioSource>();
        robotRenderer = GetComponentsInChildren<SkinnedMeshRenderer>();
        particles = GetComponentInChildren<ParticleSystem>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if(robotIsAlive)
            robotPosition.Translate(Vector3.forward * Time.deltaTime);

        if(!robotIsAlive)
        {
            if (particles.isStopped && !audioPlayer.isPlaying)
                Destroy(robotObject);
                
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Sword" && robotIsAlive)
        {
            Debug.Log("Slash t mor");
            audioPlayer.Play();
            particles.Play();
            robotIsAlive = false;
            robotRenderer[0].enabled = false;
            robotRenderer[1].enabled = false;
        }
            
    }
}

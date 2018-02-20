using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadMiniGame : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(LoadMiniGameScene);
	}

    void LoadMiniGameScene()
    {
        try { SceneManager.LoadScene(GetComponentInChildren<Text>().text); }
        catch(Exception e) { Debug.Log(e.Message); }
    }
}

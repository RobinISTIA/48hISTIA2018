using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadBoard : MonoBehaviour {

    [SerializeField] private Button OnePlayer;
    [SerializeField] private Button TwoPlayers;
    [SerializeField] private Button ThreePlayers;
    [SerializeField] private Button FourPlayers;

    [SerializeField] private GlobalVariables gl;

    // Use this for initialization
    void Start () {
        OnePlayer.onClick.AddListener(() => { LoadBordScene(1); });
        TwoPlayers.onClick.AddListener(() => { LoadBordScene(2); });
        ThreePlayers.onClick.AddListener(() => { LoadBordScene(3); });
        FourPlayers.onClick.AddListener(() => { LoadBordScene(4); });
    }

    void LoadBordScene(uint nbPlayer)
    {
        gl.NumberOfPlayers = nbPlayer;
        SceneManager.LoadScene("Board");
    }
	
	
}

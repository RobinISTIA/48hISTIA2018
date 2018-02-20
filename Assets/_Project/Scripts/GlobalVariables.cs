using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalVariables : MonoBehaviour {

    private static GlobalVariables _instance;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        IsWon = null;
        NumberOfPlayers = 2;
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    public bool? IsWon {
        get {            
            return IsWon;
        }
        set {
            IsWon = value;
            if(value != null) SceneManager.LoadScene("Board");
        } }

    public uint NumberOfPlayers { get; set; }
    public static GlobalVariables Instance { get { return _instance; } }
}

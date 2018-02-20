using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour {

    private void Start()
    {
        IsWon = false;
        NumberOfPlayers = 2;
    }

    public bool IsWon { get; set; }
    public uint NumberOfPlayers { get; set; }
}

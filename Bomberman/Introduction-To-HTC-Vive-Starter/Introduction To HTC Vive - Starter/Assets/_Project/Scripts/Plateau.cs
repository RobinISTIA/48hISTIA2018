using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateau : MonoBehaviour {

    
    public GameObject Tableau;
    private int[][] tableau;

    public Plateau() { }

    public void Init(int row, int col)
    {
        // initialisation du tableau de gestion du plateau (11*11)
        tableau = new int[row][];
        for(int i=0; i<tableau.Length;i++)
        {
            tableau[i] = new int[col];
        }

        // initialisation des blocs incassables
        for(int i=1; i<tableau.Length; i+=2)
        {
            for(int j=1; j<tableau.Length; j += 2)
            {
                tableau[i][j] = Bloc.BLOC_INCASSABLE;
            }
        }

        //initialisation des positions de départ
        tableau[0][2] = Bloc.BLOC_VIDE;
        tableau[0][1] = Bloc.BLOC_VIDE;
        tableau[0][3] = Bloc.BLOC_VIDE;
        tableau[1][2] = Bloc.BLOC_VIDE;
        tableau[10][8] = Bloc.BLOC_VIDE;
        tableau[10][7] = Bloc.BLOC_VIDE;
        tableau[10][9] = Bloc.BLOC_VIDE;
        tableau[9][8] = Bloc.BLOC_VIDE;

        //initialisation des blocs cassables
        System.Random rnd = new System.Random();
        int x, y;
        int[][] indexes = new int[tableau.Length * tableau.Length][];
        for(int i=0; i<tableau.Length*tableau.Length; i++)
        {
            x = rnd.Next(tableau.Length);
            y = rnd.Next(tableau.Length);
            
        }
    }

    public void Victory(bool vict)
    {
        //Envoie du signal de victoire

    }

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
		
	}
}

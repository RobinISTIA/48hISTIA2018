using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateau : MonoBehaviour {

    
    public GameObject Tableau;
    public Rigidbody BlocCassableOriginal;
    public Rigidbody BlocIncassableOriginal;
    private int[,] tableau;

    public Plateau() { }

    public void Init(int row, int col)
    {
        // initialisation du tableau de gestion du plateau (11*11)
        tableau = new int[row, col];

        // initialisation des blocs incassables
        for(int i=1; i<tableau.GetLength(0); i+=2)
        {
            for(int j=1; j<tableau.GetLength(1); j += 2)
            {
                tableau[i, j] = Bloc.BLOC_INCASSABLE;
            }
        }

        //initialisation des positions de départ
        tableau[0, tableau.GetLength(1) / 2] = Bloc.BLOC_VIDE; //Joueur 1
        tableau[tableau.GetLength(0)-1, tableau.GetLength(1) / 2] = Bloc.BLOC_VIDE; //Joueur 2
        // Blocs adjacents
        tableau[1, tableau.GetLength(1) / 2] = Bloc.BLOC_VIDE;
        tableau[0, (tableau.GetLength(1) / 2) - 1] = Bloc.BLOC_VIDE;
        tableau[0, (tableau.GetLength(1) / 2) + 1] = Bloc.BLOC_VIDE;
        tableau[tableau.GetLength(0) - 1, tableau.GetLength(1) / 2] = Bloc.BLOC_VIDE;
        tableau[tableau.GetLength(0) - 1, (tableau.GetLength(1) / 2) - 1] = Bloc.BLOC_VIDE;
        tableau[tableau.GetLength(0) - 1, (tableau.GetLength(1) / 2) + 1] = Bloc.BLOC_VIDE;

        //initialisation des blocs cassables
        System.Random rnd = new System.Random();
        List<int[]> listeXY = new List<int[]>();
        for (int i=0; i < tableau.GetLength(0); i++)
        {
            for (int j=0; j < tableau.GetLength(1); j++)
            {
                if(tableau[i, j] == 0)
                {
                    listeXY.Add(new int[] { i, j });
                }
            }
        }

        int idx;
        for (int i=0; i < listeXY.Count / 2; i++)
        {
            {
                idx = rnd.Next(listeXY.Count);
                tableau[listeXY[idx][0], listeXY[idx][1]] = Bloc.BLOC_CASSABLE;
                listeXY.RemoveAt(idx);
            }
        }

        //initialisation des blocs vides
        for(int i=0; i<row; i++)
        {
            for(int j=0; j<col; j++)
            {
                if(tableau[i, j] == 0)
                {
                    tableau[i, j] = Bloc.BLOC_VIDE;
                }
            }
        }
    }

    public void Victory()
    {
        //Envoie du signal de victoire

    }

    public void Explosion()
    {

    }

    public void PlayerMoved()
    {

    }

	// Use this for initialization
	void Start ()
    {
        Debug.Log("Start Plateau");
        this.Init(30/3, 30/3);
        Debug.Log("Fin Init Plateau");
        for (int x = 0; x < tableau.GetLength(0); x++)
        {
            for (int z = 0; z < tableau.GetLength(1); z++)
            {
                Instantiate(BlocCassableOriginal, new Vector3(x, 1.5f, z), Quaternion.identity);
            }
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}

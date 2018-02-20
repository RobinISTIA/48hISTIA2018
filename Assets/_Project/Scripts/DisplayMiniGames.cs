using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMiniGames : MonoBehaviour {

    [SerializeField] private GameObject miniGameButton;
    private List<List<GameObject>> gameButtonsPages = new List<List<GameObject>>();
    private string[] gameNames = new string[] { "Bomberman", "ZSnipes", "DodgeGame", "ToyShooty", "DigitalJousting" };

	// Use this for initialization
	void Start () {
        //Display the same number of button as the number of minigames
        //If more than 5 minigames, stack them in different pages
        for (int j = 0; j < gameNames.Length / 5 ; j++)
        {
            gameButtonsPages.Add(new List<GameObject>());
            for (int i = 0; i < gameNames.Length; i++)
            {
                gameButtonsPages[j].Add(Instantiate(miniGameButton));
                gameButtonsPages[j][i].transform.SetParent(miniGameButton.transform.parent);
                gameButtonsPages[j][i].transform.position = miniGameButton.transform.position;
                gameButtonsPages[j][i].transform.Translate(230 * (i % 3), -120 * (i % 2), 0);
                gameButtonsPages[j][i].GetComponentInChildren<Text>().text = gameNames[i];
            }
            if (j > 0) foreach (GameObject button in gameButtonsPages[j]) button.SetActive(false);

        }

        miniGameButton.gameObject.SetActive(false);
	}
}

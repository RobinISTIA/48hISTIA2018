using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchToGameChoice : MonoBehaviour {

    [SerializeField] private GameObject GameChoiceButtons;

    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(setActiveGameChoiceButtons);
    }

    void setActiveGameChoiceButtons()
    {
        gameObject.transform.parent.gameObject.SetActive(false);
        GameChoiceButtons.SetActive(true);
    }
}

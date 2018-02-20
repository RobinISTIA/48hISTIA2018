using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackToMainButtons : MonoBehaviour {

    [SerializeField] private GameObject mainButtons;

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(setActiveMainButtons);
    }

    void setActiveMainButtons()
    {
        gameObject.transform.parent.gameObject.SetActive(false);
        mainButtons.SetActive(true);
    }
}

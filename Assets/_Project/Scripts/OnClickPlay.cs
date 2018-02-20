using UnityEngine;
using UnityEngine.UI;

public class OnClickPlay : MonoBehaviour {

    [SerializeField] private GameObject partySelector;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Button>().onClick.AddListener(setActiveChooseNumberOfPlayer);
	}

    void setActiveChooseNumberOfPlayer()
    {
        gameObject.transform.parent.gameObject.SetActive(false);
        partySelector.SetActive(true);
    }
}

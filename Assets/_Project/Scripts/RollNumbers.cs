using System.Collections;
using UnityEngine;
using System;
using UnityEngine.UI;

public class RollNumbers : MonoBehaviour {

    [SerializeField] private TextMesh textNumberLeft;
    [SerializeField] private TextMesh textNumberRight;
    [SerializeField] private float WAITINGTIME = 0.05f;
    private bool isRunningCRLeft = false, isRunningCRRight = false;
    private uint minimumTimeSpent = 10;

    public void RollUntilNumber(uint forwardScore)
    {
        if(!isRunningCRLeft) //allow not to run the coroutine multiple times at once
        {
            isRunningCRLeft = true;
            StartCoroutine(Roll(textNumberLeft, forwardScore, WAITINGTIME));
        }
        if (!isRunningCRRight)
        {
            isRunningCRRight = true;
            StartCoroutine(Roll(textNumberRight, forwardScore, WAITINGTIME*1.5f));
        }
    }

    IEnumerator Roll(TextMesh textNumber, uint forwardScore, float waitingTime)
    {
        if (forwardScore < 2) yield break;
        uint number = 0, timeSpent = 0;
        while (UInt32.Parse(textNumberLeft.text) + UInt32.Parse(textNumberRight.text) != forwardScore || timeSpent < minimumTimeSpent)
        {
            Debug.Log(timeSpent);

            yield return new WaitForSeconds(waitingTime);

            UInt32.TryParse(textNumber.text, out number);
            textNumber.text = (number % 6 + 1).ToString();

            timeSpent++;
        }

        isRunningCRLeft = false;
        isRunningCRRight = false;
    }

}

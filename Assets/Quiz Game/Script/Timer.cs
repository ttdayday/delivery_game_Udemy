using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnser = 10f;
    float timerValue;
    public bool isAnsweringQuestion = false;

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;
        if (isAnsweringQuestion)
        {
            if (timerValue <= 0)
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnser;
            }
        }
        else
        {
            if (timerValue <= 0)
            {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
            }
        }

        Debug.Log(timerValue);
    
    }

    


}

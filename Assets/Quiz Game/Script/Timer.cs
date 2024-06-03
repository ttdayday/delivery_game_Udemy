using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    float timerValue;
    public bool loadNextQuestion;
    public bool isAnsweringQuestion = false;
    public float fillFraction;

    void Start()
    {
        timerValue = timeToCompleteQuestion;
        isAnsweringQuestion = true;
    }

    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;
        if (isAnsweringQuestion)
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            }
            else
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
            else
            {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }

       // Debug.Log(isAnsweringQuestion + ":" + timerValue + "=" + fillFraction);
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }
}

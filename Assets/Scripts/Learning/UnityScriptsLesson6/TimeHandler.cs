using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeHandler : MonoBehaviour
{
    public Text timerText;
    public Text loopsCounterText;
    public Text currentLoopTimeText;
    public Text previousLoopTimeText;

    private float currentLoopTime;
    private float currentTime;
    private float currentLoop = 0;
    //private float number;
    private float previousLoopTime;
    private bool IsTimerOn = false;
    private float initialTime;

    void Start()
    {
        //number = -0.5f;
        //Debug.Log(Mathf.Round(number));
    
    }

    void Update()
    {
        //Debug.Log(Time.time); //: чтобы вывести время в секундах в консоль.
        //timerText.text = ""; : чтобы вывести текст в значение переменной.

        //if (currentTime % 10 == 0)
        // {
        //     currentLoop = currentTime / 10;
        //     loopsCounterText.text = currentLoop.ToString();        : наше решение.
        // }

        
        if (IsTimerOn)
        {
            currentTime = Mathf.Round(Time.time - initialTime); // используем метод Mathf.Round для округления переменной типа float Time.time.
            timerText.text = currentTime.ToString(); // обращаемся к переменной currentTime для её вывода в поле Text.
        }

        //currentTime = Mathf.Round(Time.time); // используем метод Mathf.Round для округления переменной типа float Time.time.
        // timerText.text = currentTime.ToString(); // обращаемся к переменной currentTime для её вывода в поле Text.
        //loopsCounterText.text = Mathf.Round((currentTime - 4) / 10).ToString(); : решение Скиллбокса.
}

    public void LoopsFinishedButtonClick()
    {
        CalculateRaceData();
        DisplayRaceData();
    }

    private void CalculateRaceData()
    {
        previousLoopTime = currentLoopTime;
        currentLoopTime = currentTime;
        currentLoop += 1;
    }

    private void DisplayRaceData()
    {
        currentLoopTimeText.text = currentLoopTime.ToString();
        previousLoopTimeText.text = previousLoopTime.ToString();
        loopsCounterText.text = currentLoop.ToString();
    }
    
    public void BeginRaceButtonClick()
    {
        initialTime = Time.time; 
        IsTimerOn = true;
    }
}

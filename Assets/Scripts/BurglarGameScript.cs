using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BurglarGameScript : MonoBehaviour
{
    [SerializeField] public int originFirstPinNumber;
    [SerializeField] public int originSecondPinNumber;
    [SerializeField] public int originThirdPinNumber;

    [SerializeField] public Text firstPinText;
    [SerializeField] public Text secondPinText;
    [SerializeField] public Text thirdPinText;
    [SerializeField] public Text timerText;

    [SerializeField] private GameObject WinningPanel;
    [SerializeField] private GameObject LosingPanel;

    [SerializeField] private GameObject GameCanvas;
    [SerializeField] private GameObject MessagesCanvas;


    private int currentFirstPinNumber;
    private int currentSecondPinNumber;
    private int currentThirdPinNumber;

    private float currentTime;

    private bool IsDrillButtonClicked = false;
    private bool IsHammerButtonClicked = false;
    private bool IsLockpickButtonClicked = false;
    private bool IsTimerOn = false;

    private int max = 10;
    private int min = 0;
    private float timerMaxtime = 60f;
    private float timerMinTime = 0f;
    private float timeTimerStopped = 0f;

   

    private GameObject currentCanvas;
    private GameObject currentMessagesCanvasPanel;

    void Start()
    {
        DisplayOriginPinsNumbers();

        currentFirstPinNumber = originFirstPinNumber;
        currentSecondPinNumber = originSecondPinNumber;
        currentThirdPinNumber = originThirdPinNumber;

        IsTimerOn = true;
        timeTimerStopped = Time.time;
        currentTime = timerMaxtime;


        GameCanvas.SetActive(true);
        MessagesCanvas.SetActive(false);
        currentCanvas = GameCanvas;

        WinningPanel.SetActive(false);
        LosingPanel.SetActive(false);
        currentMessagesCanvasPanel = WinningPanel;

    }

    void Update()
    {

        if (IsTimerOn == true)
        {
            if (currentTime > timerMinTime)
            {
                currentTime = Mathf.Round(timerMaxtime - Time.time + timeTimerStopped);
                timerText.text = currentTime.ToString();
            }
            else
            {
                LosingPanelOn();
            }
        }

    }

    public void OnDrillButtonClick()
    {
        CalculateCurrentPinsNumbersOnDrillButtonClicked();
        PinNumbersCheck();
        DisplayCurrentPinsNumbersOnDrillButtonClicked();
        ChangeState();
    }

    public void OnHammerButtonClick()
    {
        CalculateCurrentPinsNumbersOnHammerButtonClicked();
        PinNumbersCheck();
        DisplayCurrentPinsNumbersOnHammerButtonClicked();
        ChangeState();
    }

    public void OnLockpickButtonClick()
    {
        CalculateCurrentPinsNumbersOnLockpickButtonClicked();
        PinNumbersCheck();
        DisplayCurrentPinsNumbersOnLockpickButtonClicked();
        ChangeState();
    }

    private void CalculateCurrentPinsNumbersOnDrillButtonClicked()
    {
        currentFirstPinNumber += 1;
        currentSecondPinNumber -= 1;

        IsDrillButtonClicked = true;
    }
    private void CalculateCurrentPinsNumbersOnHammerButtonClicked()
    {
        currentFirstPinNumber -= 1;
        currentSecondPinNumber += 2;
        currentThirdPinNumber -= 1;

        IsHammerButtonClicked = true;
    }

    private void CalculateCurrentPinsNumbersOnLockpickButtonClicked()
    {
        currentFirstPinNumber -= 1;
        currentSecondPinNumber += 1;
        currentThirdPinNumber += 1;

        IsLockpickButtonClicked = true;
    }

    private void DisplayOriginPinsNumbers()
    {
        firstPinText.text = originFirstPinNumber.ToString();
        secondPinText.text = originSecondPinNumber.ToString();
        thirdPinText.text = originThirdPinNumber.ToString();
    }

    private void DisplayCurrentPinsNumbersOnDrillButtonClicked()
    {
        if (IsDrillButtonClicked)
        {
            firstPinText.text = currentFirstPinNumber.ToString();
            secondPinText.text = currentSecondPinNumber.ToString();
            thirdPinText.text = currentThirdPinNumber.ToString();
        }

    }

    private void DisplayCurrentPinsNumbersOnHammerButtonClicked()
    {
        if (IsHammerButtonClicked)
        {
            firstPinText.text = currentFirstPinNumber.ToString();
            secondPinText.text = currentSecondPinNumber.ToString();
            thirdPinText.text = currentThirdPinNumber.ToString();
        }

    }

    private void DisplayCurrentPinsNumbersOnLockpickButtonClicked()
    {
        if (IsLockpickButtonClicked)
        {
            firstPinText.text = currentFirstPinNumber.ToString();
            secondPinText.text = currentSecondPinNumber.ToString();
            thirdPinText.text = currentThirdPinNumber.ToString();
        }

    }

    private void PinNumbersCheck()
    {
        if (currentFirstPinNumber > max)
        {
            currentFirstPinNumber = max;
        }
        else if (currentFirstPinNumber < min)
        {
            currentFirstPinNumber = min;
        }

        if (currentSecondPinNumber > max)
        {
            currentSecondPinNumber = max;
        }
        else if (currentSecondPinNumber < min)
        {
            currentSecondPinNumber = min;
        }

        if (currentThirdPinNumber > max)
        {
            currentThirdPinNumber = max;
        }
        else if (currentThirdPinNumber < min)
        {
            currentThirdPinNumber = min;
        }
    }

    public void ChangeState()
    {
        if (currentFirstPinNumber == 6 && currentSecondPinNumber == 6 && currentThirdPinNumber == 6 && currentCanvas != null)
        {
            WinningPanelOn();
        }

    }

    public void ReloadButtonClicked()
    {
        
        MessagesCanvas.SetActive(false);

        IsDrillButtonClicked = false;
        IsHammerButtonClicked = false;
        IsLockpickButtonClicked = false;

        Start();

    }

    public void WinningPanelOn()
    {
        IsTimerOn = false;
        currentMessagesCanvasPanel = WinningPanel;
        MessagesCanvas.SetActive(true);
        currentMessagesCanvasPanel.SetActive(true);

    }

    public void LosingPanelOn()
    {
        IsTimerOn = false;
        currentMessagesCanvasPanel = LosingPanel;
        MessagesCanvas.SetActive(true);
        currentMessagesCanvasPanel.SetActive(true);
    }
}
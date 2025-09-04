using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuState10Script : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;

    public GameObject MenuCanvas;

    public bool RestartGames;

    public bool ResetWreckingBall;
    public bool ResetPinball;


    public InitiateObjectsScript IOS;
    public InstantiatePinballScript IPS;



    void Start()
    {
        p1.SetActive(false);
        p2.SetActive(false);
        MenuCanvas.SetActive(true);
    }

    public void OnWreckingBallButtonClick()
    {
        p1.SetActive(true);
        MenuCanvas.SetActive(false);

    }

    public void OnPinballButtonClick()
    {
        p2.SetActive(true);
        MenuCanvas.SetActive(false);

    }

    public void OnBackToMenuButtonClick()
    {
        RestartGames = true;
        MenuCanvas.SetActive(true);
        p1.SetActive(false);
        p2.SetActive(false);
    }

    public void OnWreckingBallBackToMenuButtonClick()
    {
        ResetWreckingBall = true;
        OnBackToMenuButtonClick();
    }

    public void OnPinballBackToMenuButtonClick()
    {
        ResetPinball = true;
        OnBackToMenuButtonClick();
    }
    void FixedUpdate()
    {
        if (RestartGames == true)
        {
            if (ResetWreckingBall == true)
            {
                Destroy(IOS.CWreckingBall);
                IOS.CWreckingBall = Instantiate(IOS.WreckingBall, new Vector3(0, 3.147f, 1.439f), Quaternion.Euler(-90, 0, 0), p1.transform);

                Destroy(IOS.CBricks);
                IOS.CBricks = Instantiate(IOS.Bricks, new Vector3(-0.375f, 1.081f, -1.808f), Quaternion.Euler(0, 0, 0), p1.transform);

                ResetWreckingBall = false;
            }

            if (ResetPinball == true)
            {
                Destroy(IPS.CActivePinball);
                IPS.CActivePinball = Instantiate(IPS.ActivePinball, new Vector3(-11.92f, 0.94f, 17.91f), Quaternion.Euler(0, 90, 0), p2.transform);

                Destroy(IPS.CBalls);
                IPS.CBalls = Instantiate(IPS.Balls, new Vector3(-11.86f, 0.84f, 17.9f), Quaternion.Euler(0, 90, 0), p2.transform);

                ResetPinball = false;
            }
                RestartGames = false;
          
        }
    }
}

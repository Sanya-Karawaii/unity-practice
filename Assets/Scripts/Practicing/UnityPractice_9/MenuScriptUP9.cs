using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScriptUP9 : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject MenuCanvas;
    public GameObject MainCamera;

    public bool RestartGames;

    public SupermanScript SS;
    public BilliardTableScript BTS;
    public ZeroGravitySphereScript ZGSS;


    public void Start()
    {
        p1.SetActive(false);
        p2.SetActive(false);
        MenuCanvas.SetActive(true);
        MainCamera.SetActive(true);

    }

    public void OnPointToPointButtonClick()
    {
        p1.SetActive(true);
        MenuCanvas.SetActive(false);
        MainCamera.SetActive(false);
    }

    public void OnRunnersCompetitionButtonClick()
    {
        p2.SetActive(true);
        MenuCanvas.SetActive(false);
        MainCamera.SetActive(false);
    }

    public void OnBackToMenuButtonClick()
    {
        RestartGames = true;
        MenuCanvas.SetActive(true);
        MainCamera.SetActive(true);
        p1.SetActive(false);
        p2.SetActive(false);
    }

    public void FixedUpdate()
    {
        if (RestartGames == true)
        {
            
        }
    }

}
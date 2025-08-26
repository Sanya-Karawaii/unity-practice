using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject MenuCanvas;
    public GameObject MainCamera;

    public bool RestartGames;

    public PointToPointSystemScript pTp;
    public RunnersCompetitionScript runners;

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
            pTp.i = 0;
            runners.i1 = 1;
            runners.i2 = 0;
            runners.ToPoint = true;
            runners.ToRunner = false;
            runners.RestartCycle = false;
            runners.MainRunner = runners.Runner1;
            runners.LastRunner = runners.Runner4;
            runners.FirstRunner = runners.Runner1;
            pTp.MainObject.transform.position = new Vector3(-6.12f, -3.12f, -2.573f);
            pTp.target = pTp.positions[pTp.i];
            runners.Runner1.transform.position = new Vector3(0.43f, -1.83f, 0.47f);
            runners.Runner2.transform.position = new Vector3(2.89f, 0.11f, 0.47f);
            runners.Runner3.transform.position = new Vector3(-0.81f, 3.05f, 0.47f);
            runners.Runner4.transform.position = new Vector3(-3.15f, 1.15f, 0.47f);
            runners.Stick.transform.position = new Vector3(0.8460364f, -1.422056f, 0.346f);
            runners.Stick.transform.SetParent(runners.MainRunner.transform);
            runners.NextPosition = runners.RunnerPositions[runners.i1];
            runners.NextPoint = runners.AdditionalPositions[runners.i2];
            RestartGames = false;
        }
    }

}

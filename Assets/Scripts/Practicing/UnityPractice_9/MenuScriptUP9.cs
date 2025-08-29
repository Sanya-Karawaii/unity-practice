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
    //public GameObject MainCamera;

    public bool RestartGames;

    public SupermanScript SS;
    public BilliardTableScript BTS;
    public ZeroGravitySphereScript ZGSS;
    public BlastScript BS;

    public bool ResetSuperman;
    public bool ResetBilliard;
    public bool ResetSphere;




    public void Start()
    {
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
        MenuCanvas.SetActive(true);
        //MainCamera.SetActive(true);

    }

    public void OnSupemanButtonClick()
    {
        p1.SetActive(true);
        MenuCanvas.SetActive(false);
        //MainCamera.SetActive(false);
    }

    public void OnBilliardTableButtonClick()
    {
        p2.SetActive(true);
        MenuCanvas.SetActive(false);
        //MainCamera.SetActive(false);
    }

    public void OnZeroGravitySphereButtonClick()
    {
        p3.SetActive(true);
        MenuCanvas.SetActive(false);
        //MainCamera.SetActive(false);
    }

    public void OnBackToMenuButtonClick()
    {
        RestartGames = true;
        MenuCanvas.SetActive(true);
        //MainCamera.SetActive(true);
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
    }

    public void OnSupermanBackToMenuButtonClick()
    {
        ResetSuperman = true;
        OnBackToMenuButtonClick();
    }

    public void OnBilliardBackToMenuButtonClick()
    {
        ResetBilliard = true;
        OnBackToMenuButtonClick();
    }

    public void OnSphereBackToMenuButtonClick()
    {
        ResetSphere = true;
        OnBackToMenuButtonClick();
    }

    public void FixedUpdate()
    {
        if (RestartGames == true)
        {
            if (ResetSuperman == true)
            {
                SS.Superman.transform.position = SS.SupermanPosition;
                SS.r.velocity = Vector3.zero;

                Destroy(SS.CloneBadGuys);
                SS.CloneBadGuys = Instantiate(SS.BadGuys, Vector3.zero, Quaternion.Euler(0, 0, 0), p1.transform);

                ResetSuperman = false;
            }

            if (ResetBilliard == true)
            {
                BTS.BilliardBall.transform.position = BTS.BilliardBallPosition;

                BTS.kickTheBall = true;

                Destroy(BTS.CloneOtherBalls);
                BTS.CloneOtherBalls = Instantiate(BTS.OtherBalls, new Vector3(0, -0.59f, -4.94f), Quaternion.Euler(0, 0, 0), p2.transform);

                ResetBilliard = false;

            }

            if (ResetSphere == true)
            {
                Destroy(ZGSS.ClonePracticeObjects);
                ZGSS.ClonePracticeObjects = Instantiate(ZGSS.PracticeObjects, Vector3.zero, Quaternion.Euler(0, 0, 0), p3.transform);

                BS.TimeToExplosion = 3;

                ResetSphere = false;
            }

                RestartGames = false;
        }
    }

}
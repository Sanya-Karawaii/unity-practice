using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void OnPointToPointButtonClick()
    {
        SceneManager.LoadScene("UnityPractice_8(p1)");
    }

    public void OnRunnersCompetitionButtonClick()
    {
        SceneManager.LoadScene("UnityPractice_8(p2)");
    }

    public void OnBackToMenuButtonClick()
    {
        SceneManager.LoadScene("MenuScene");
    }
}

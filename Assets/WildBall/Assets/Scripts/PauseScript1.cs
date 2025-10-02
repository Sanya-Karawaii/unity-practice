using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript1 : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject MenuPanel;
    public GameObject FinishCanvas;
    private GameObject CurrentPanel;
    private GameObject[] particlesSys;
    private ParticleSystem part;


    void Start()
    {
        CurrentPanel = PausePanel;
        CurrentPanel.SetActive(true);
    }

    
    public void OnPauseButtonClick()
    {
        Time.timeScale = 0;
        CurrentPanel.SetActive(false);
        CurrentPanel = MenuPanel;
        CurrentPanel.SetActive(true);
    }

    public void OnBackToGameButtonClick()
    {
        Time.timeScale = 1;
        CurrentPanel.SetActive(false);
        CurrentPanel = PausePanel;
        CurrentPanel.SetActive(true);
    }

    public void OnReloadLevelButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnBackToMenuButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void GameWin()
    {
        CurrentPanel.SetActive(false);
        CurrentPanel = FinishCanvas;
        CurrentPanel.SetActive(true);
        particlesSys = GameObject.FindGameObjectsWithTag("Particles");

        foreach (GameObject par in particlesSys)
        {
            part = par.GetComponent<ParticleSystem>();
            part.Play();
        }
    }
}

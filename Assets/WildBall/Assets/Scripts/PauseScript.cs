using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject MenuPanel;
    private GameObject CurrentPanel;

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
}

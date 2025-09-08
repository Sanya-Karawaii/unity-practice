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
        CurrentPanel.SetActive(false);
        CurrentPanel = MenuPanel;
        CurrentPanel.SetActive(true);
    }

    public void OnBackToGameButtonClick()
    {
        CurrentPanel.SetActive(false);
        CurrentPanel = PausePanel;
        CurrentPanel.SetActive(true);
    }

    public void OnReloadLevelButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnBackToMenuButton()
    {
        SceneManager.LoadScene(0);
    }
}

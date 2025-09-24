using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScriptUP12 : MonoBehaviour
{
    public int Scene;

    private GameObject CurrentCanvas;

    public GameObject MainCanvas;
    public GameObject SelectLevelCanvas;

    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;
    public GameObject Level5;


    void Start()
    {
        CurrentCanvas = MainCanvas;
        CurrentCanvas.SetActive(true);
    }

    public void OnPlayButtonClick()
    {
        CurrentCanvas.SetActive(false);
        CurrentCanvas = SelectLevelCanvas;
        CurrentCanvas.SetActive(true);
    }

    public void BackToMenuButtonClick()
    {
        CurrentCanvas.SetActive(false);
        CurrentCanvas = MainCanvas;
        CurrentCanvas.SetActive(true);
    }

    public void OnLevelButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + Scene);
    }

    public void OnLevel1Click()
    {
        Scene = 1;
        OnLevelButtonClick();
    }

    public void OnLevel2Click()
    {
        Scene = 2;
        OnLevelButtonClick();
    }

    public void OnLevel3Click()
    {
        Scene = 3;
        OnLevelButtonClick();
    }

}

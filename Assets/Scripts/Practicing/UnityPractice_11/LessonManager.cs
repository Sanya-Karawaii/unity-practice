using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LessonManager : MonoBehaviour
{
    
    public void OnToFakeCanvasButtonClick()
    {
        SceneManager.LoadScene(0);
    }

    public void OnToAnimationButtonClick()
    {
        SceneManager.LoadScene(7);
    }

    public void OnToBallAnimationButtonClick()
    {
        SceneManager.LoadScene(8);
    }

    public void OnBackToLessonManagerButton()
    {
        SceneManager.LoadScene(6);
    }
}

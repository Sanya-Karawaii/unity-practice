using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonUI : MonoBehaviour
{
    public GameObject buttonPanel;
    public bool IsItDone = false;

    public void OnCollisionEnter(Collision player)
    {
        if (IsItDone == false)
        {
            buttonPanel.SetActive(true);
        }
    }

    public void OnCollisionExit(Collision player)
    {
        buttonPanel.SetActive(false);
    }

}

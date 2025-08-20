using UnityEngine;
using UnityEngine.UI;
using System;

public class GuessNumberScript : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private InputField inputField;

    private int value = 0;

    private void Start()
    {
        value = UnityEngine.Random.Range(0, 101);
        

    }

    public void onCheckClicked()
    {
        if (inputField.text.Equals(value.ToString()))
        {
            text.text = "Вы угадали!";
        }
        else if (Convert.ToInt32(inputField.text) < value)
        {
            text.text = "Загаданное число больше!";
        }
        else if (Convert.ToInt32(inputField.text) > value)
        {
            text.text = "Загаданное число меньше!";
        }
    }

}

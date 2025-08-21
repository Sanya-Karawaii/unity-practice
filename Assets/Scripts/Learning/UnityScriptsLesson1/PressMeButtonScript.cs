using UnityEngine;
using UnityEngine.UI;

public class PressMeButtonScript : MonoBehaviour
{
    public Text counter;
    // Text - компонент Канваса, который связывается со скриптом.
    public InputField inputField;
    int a = 0;

    private void Start()
    {
        counter.text = "0";
    }

    public void onPress()
    {
        //Debug.Log(++a);
        counter.text = (++a).ToString();
        //counter - название переменной, text - название нужного поля в компоненте.

    }

    public void readText()
    {
        if (inputField.text == "")
        {
            counter.text = "Enter the text!";

        }
        else
        {
            counter.text = inputField.text;
        }
        
    }
}

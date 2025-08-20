using UnityEngine;
using UnityEngine.UI;

public class PressMeButtonScript : MonoBehaviour
{
    public Text counter;
    // Text - ��������� �������, ������� ����������� �� ��������.
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
        //counter - �������� ����������, text - �������� ������� ���� � ����������.

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

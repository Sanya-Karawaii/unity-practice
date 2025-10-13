using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    [SerializeField] private GameObject notificationPanel;
    [SerializeField] private Text maxHealthText;
    [SerializeField] private Text currentHealthText;
    [SerializeField] private Image HealthIndicator;

    private float currentHealth = 0;

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Update()
    {
        currentHealthText.text = currentHealth.ToString();
    }

    public void CheckCurrentHealth()
    {
        if (currentHealth == 0)
        {
            notificationPanel.SetActive(true);
        }
        //����� �������� = 0; �������� ����� ������
        //��������� ���������� ������� � ������������ �������� ������ � ��������������� ��������� ����
        //�� ������� ������ ������������ ������ - ������������� �������

    }
}

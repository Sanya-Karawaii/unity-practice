using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameState_18 : MonoBehaviour
{
    [SerializeField] private GameObject notificationPanel;
    [SerializeField] private Text maxHealthText;
    [SerializeField] private Text currentHealthText;
    [SerializeField] private Image HealthIndicator;

    [SerializeField] private GameObject Player;
    private HealthScript_18 hs;

    public void Start()
    {

    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void CheckCurrentHealth(float currentHealth)
    {
        StartCoroutine(IsDead());

    }

    public void DisplayHealthStatus(float maxHealth, float currentHealth)
    {
        maxHealthText.text = maxHealth.ToString();
        currentHealthText.text = currentHealth.ToString();
    }

    public void ChangeHealthIndicator(float damage)
    {
        HealthIndicator.fillAmount -= damage * 0.01f;
    }

    private IEnumerator IsDead()
    {
        yield return new WaitForSeconds(2);
        notificationPanel.SetActive(true);
    }


}

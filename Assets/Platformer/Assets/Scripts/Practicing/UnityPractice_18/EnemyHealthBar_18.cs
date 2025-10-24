using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar_18 : MonoBehaviour
{
    [SerializeField] public Slider healthBar;

    public void ChangeHealthBar(float damage)
    {
        healthBar.value -= damage * 0.01f;
    }



}

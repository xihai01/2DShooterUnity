using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public UnityEngine.UI.Slider healthBar;
    public Health playerHealth;

    private void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        healthBar = GetComponent<UnityEngine.UI.Slider>();
        healthBar.maxValue = playerHealth.maximumHealth;
        healthBar.value = playerHealth.maximumHealth;
    }

    public void SetHealth(int hp)
    {
        healthBar.value = hp;
    }
}

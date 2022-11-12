using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] public float health;
    public float currentHealth { get; private set; }

    private void Awake()
    {
        currentHealth = health;
    }

    public void Damage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, health);

        if (currentHealth > 0)
        {

        }
        else
        {

        }
    }
}

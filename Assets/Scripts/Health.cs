using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] public float health;
    public float currentHealth { get; private set; }
    public GameObject player;
    public GameObject DeathPanel;

    private void Awake()
    {
        currentHealth = health;
    }

    public void Damage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, health);

        if (currentHealth == 0)
        {
            Destroy(player, 0.15f);
            Cursor.visible = true;
            DeathPanel.SetActive(true);
        }
        else
        {

        }
    }
}

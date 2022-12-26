using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lovushka : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject trigger;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("player"))
        {
            rb.isKinematic = false;
            trigger.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Trigger_Lovushca : MonoBehaviour
{
    
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("player"))
        {
            rb.isKinematic= false;
        }
    }
}

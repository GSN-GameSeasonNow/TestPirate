using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xSpeed : MonoBehaviour
{
    [SerializeField] public Player xspeed;
    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Player>().Speed(3);
        }
    }
}

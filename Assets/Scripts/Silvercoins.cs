using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silvercoins : MonoBehaviour
{
    public AudioSource SilverCoin;
    // Start is called before the first frame update
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
            SilverCoin.Play();
            SilverText.Coins++;
            Destroy(gameObject,0.25f);
        }
    }
}
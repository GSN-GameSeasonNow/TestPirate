using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger_BG : MonoBehaviour
{
    public Image caveBG;
    public GameObject bossCrab;
    public AudioSource oST;
    void Start()
    {
        caveBG.enabled = false;
        bossCrab.SetActive(false);
        oST.Stop();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        caveBG.enabled = true;
        bossCrab.SetActive(true);
        oST.Play();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //caveBG.enabled = false;
        //oST.Stop();
        //bossCrab.SetActive(false);
    }
}

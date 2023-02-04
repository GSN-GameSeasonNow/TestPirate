using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform ShotPos;
    public GameObject bullet;
    public AudioSource fire;
    public float clickDelay = 0.5f;
    private float nextClickTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > nextClickTime)
        {
            nextClickTime = Time.time + clickDelay;
            fire.Play();
            Instantiate(bullet, ShotPos.transform.position, transform.rotation);  
        }
    }
    
}

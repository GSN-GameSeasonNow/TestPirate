using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Weapon_totem : MonoBehaviour
{
    public GameObject bullet;
    public Transform startFirePos;
    private bool facingright = true;
    private float Fire;
    private float FireCD;
    public float destroyTime = 2f;

    void Start()
    {
        FireCD = 1f;
        Flip();
        StartCoroutine(FireCoroutine());
    }


    public void Flip()
    {
        facingright = !facingright;
        transform.Rotate(0f, 180f, 0f);
    }

    private IEnumerator FireCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(FireCD);
            GameObject fire = Instantiate(bullet, startFirePos.transform.position, transform.rotation);
            Destroy(fire, destroyTime);
        }
    }
}
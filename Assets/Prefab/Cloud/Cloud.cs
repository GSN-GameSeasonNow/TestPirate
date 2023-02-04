using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public GameObject[] cloudPrefabs;
    public float spawnTime = 3f;
    public float cloudSpeed = 0.1f;

    void Start()
    {
        InvokeRepeating("SpawnCloud", 0f, spawnTime);
    }

    void SpawnCloud()
    {
        int randomIndex = Random.Range(0, cloudPrefabs.Length);
        GameObject randomCloud = cloudPrefabs[randomIndex];
        Vector2 spawnPoint = new Vector2(transform.position.x, transform.position.y);
        GameObject newCloud = Instantiate(randomCloud, spawnPoint, Quaternion.identity);
        newCloud.GetComponent<Rigidbody2D>().velocity = new Vector2(-cloudSpeed, 0);
        Destroy(newCloud, 4f);
    }
}
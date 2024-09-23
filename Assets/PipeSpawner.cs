using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 1;

    // Start is called before the first frame update
    void Start()
    {
    //Spawns pipes just off screen 
        InvokeRepeating("spawnPipes", 1f, 1f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }

    }

    //Allows pipe location to vary vertically
    void spawnPipes()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),0), transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 2.3f;
    private float timer = 0;

    public float PipeheightOffSet = 8;


    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {

        if(timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }


      
    }


    void SpawnPipe()
    {

        float lowestPoint = transform.position.y - PipeheightOffSet;
        float highestPoint = transform.position.y + PipeheightOffSet;


        Debug.Log(transform.position.y);


        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }


}

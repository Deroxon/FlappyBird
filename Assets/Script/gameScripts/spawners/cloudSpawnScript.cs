using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudSpawnScript : MonoBehaviour
{

    public GameObject cloud;
    [SerializeField]
    private float totalTime = 0.7f;
    [SerializeField]
    private float currentTime;
    [SerializeField]
    private float CloudheightOffSet = 5;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = totalTime;

    }

    // Update is called once per frame
    void Update()
    {
        
        if(currentTime > 0)
        {
            currentTime -= Time.deltaTime;
        }
        else
        {
            spawnClouds();
            currentTime = totalTime;
        }

    }


    private void spawnClouds()
    {

        float lowestPoint = transform.position.x - CloudheightOffSet;
        float highestPoint = transform.position.y - CloudheightOffSet;

        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }

}

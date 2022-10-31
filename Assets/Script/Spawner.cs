using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private float spawnTime = 0f;
    [SerializeField]
    private GameObject[] spawnList;
    [SerializeField]
    private float endSpawnTime = 3f;
    [SerializeField]
    private float StartSpawnTime = 1f;
    private float time = 0f;

    [SerializeField]
    private float range_Start = -10f;
    [SerializeField]
    private float range_End = 10f;
    private float score = 0f;
    float a = 10;
    float speed = 8f;
    float d_time = 1.15f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        score += Time.deltaTime * 5;
        Debug.Log(score);
        if (score > a)
        {
            endSpawnTime = endSpawnTime/1.007f;
            StartSpawnTime = StartSpawnTime/1.02f;
            speed += 0.1f;
            d_time -= 0.01f;
            a += 3;
            
        }
        if (time >= spawnTime)
        {
            if(score <= 1)
            {
                Random_fun();
                spawnTime = Random.Range(StartSpawnTime, endSpawnTime);
            }
            else
            {
                Random_fun();
                Random_fun();
                spawnTime = Random.Range(StartSpawnTime, endSpawnTime);
            }
           /* if(score > 50f)
            {
                Random_fun();
                Random_fun();
                Random_fun();
                spawnTime = Random.Range(StartSpawnTime, endSpawnTime);
            }*/
            
            /*Debug.Log(transform.position);*/
        }
    }

    public void Random_fun()
    {   
       
        GameObject spawnPrefab = spawnList[Random.Range(0, spawnList.Length)];
        float range = Random.Range(range_Start, range_End);
        
        GameObject spawnObject = Instantiate(spawnPrefab, new Vector3(range, 6f, 0.05f), transform.rotation/*πÊ«‚*/, transform);
        spawnObject.GetComponent<hurdle>().moveSpeed = speed;
        spawnObject.GetComponent<hurdle>().destoryTime = d_time;


        time = 0f;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private float spawnTime = 1f;
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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= spawnTime)
        {

            Random_fun();
            Random_fun();
            spawnTime = Random.Range(StartSpawnTime, endSpawnTime);
            Debug.Log(transform.position);
        }
    }

    public void Random_fun()
    {
        GameObject spawnPrefab = spawnList[Random.Range(0, spawnList.Length)];
        float range = Random.Range(range_Start, range_End);
        transform.position = new Vector3(range, 6f, 0.05f);
        Instantiate(spawnPrefab, transform.position, transform.rotation/*πÊ«‚*/, transform);
        time = 0f;
    }
}
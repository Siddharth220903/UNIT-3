using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstaclePrefab;
    // Vector3 spawnPos = new Vector3(2.9f,0,0.03290081f);
    Vector3 spawnPos = new Vector3(12,0,0.03290081f);
    public float startDelay = 2;
    float repeatRate = 2;
    PlayerController playerControllerScript;
    void Start()
    {
        InvokeRepeating("SpawnObstacle",startDelay,repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle()
    {
        if(playerControllerScript.gameOver==false)
        {
            Instantiate(obstaclePrefab,spawnPos,obstaclePrefab.transform.rotation);
            
        }
    }
}


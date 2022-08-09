using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacle;
    private Vector3 posSpawn = new Vector3(25, 0, 0);

    private PlayerController playerControllerScript;
    private string SPAWNMANAGER_TAG = "Spawn Manager";

    private float startDelay = 2.0f;
    private float repeatRate = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnObstacle()
    {
        if (!playerControllerScript.gameOver)
        {
            Instantiate(obstacle, posSpawn, obstacle.transform.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemiesPrefabs;
    private float positionX = 20.0f;
    private float positionZ = 20.0f;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        Vector3 enemyPosition = new Vector3(Random.Range(-positionX, positionX), 0, positionZ);
        int indexEnemies = Random.Range(0, enemiesPrefabs.Length);
        Instantiate(enemiesPrefabs[indexEnemies], enemyPosition,
                enemiesPrefabs[indexEnemies].transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    private GameManager gameManager;
    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            // Instead of destroying the projectile when it leaves the screen
            //Destroy(gameObject);

            // Just deactivate it
            gameObject.SetActive(false);

        }
        else if (transform.position.z < lowerBound)
        {
            gameManager.AddLive(-1);
            Destroy(gameObject);
        }

    }
}

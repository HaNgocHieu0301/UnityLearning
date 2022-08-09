using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 20.0f;
    public float xLimit = 10;
    private PlayerController playerControllerScript;

    private string OBSTACLE_TAG = "Obstacle";

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if(transform.position.x < -xLimit && gameObject.CompareTag(OBSTACLE_TAG))
        {
            Destroy(gameObject);
        }
    }
}

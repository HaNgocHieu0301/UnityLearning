using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRg;

    public bool isOnGround = true;
    public bool gameOver;

    public float jumpForce = 40.0f;
    public float gravityModifier = 1;

    private string GROUND_TAG = "Ground";
    private string OBSTACLE_TAG = "Obstacle";

    // Start is called before the first frame update
    void Start()
    {
        playerRg = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRg.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(GROUND_TAG))
        {
            isOnGround = true;
        }else if (collision.gameObject.CompareTag(OBSTACLE_TAG))
        {
            Debug.Log("Game Over!");
            gameOver = true;
        }
    }
}

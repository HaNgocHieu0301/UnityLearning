using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 10.0f;
    [SerializeField]
    float turnSpeed = 25.0f;
    [SerializeField]
    float horizontalInput;
    [SerializeField]
    float fowardSpeed = 5.0f;

    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward*Time.deltaTime*speed);
        //transform.Translate(Vector3.left * Time.deltaTime * turnSpeed * horizontal);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        //playerRb.AddForce(Vector3.forward * speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float widthRepeat;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        widthRepeat = GetComponent<BoxCollider>().size.x/2;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position.x + " - " + (startPos.x - widthRepeat));
        if (transform.position.x < startPos.x - widthRepeat)
        {
            transform.position = startPos;
        }
    }
}

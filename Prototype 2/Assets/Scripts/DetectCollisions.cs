using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;
    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")){
            gameManager.AddLive(-1);
        }else if (other.gameObject.CompareTag("Animal"))
        {
            gameManager.AddScore(5);
            gameObject.SetActive(false);
            other.gameObject.GetComponent<AnimalHunger>().FeedAnimal(1);
        }
        // Instead of destroying the projectile when it collides with an animal
        //Destroy(other.gameObject); 
        // Just deactivate the food and destroy the animal
        //Destroy(gameObject);
    }

}

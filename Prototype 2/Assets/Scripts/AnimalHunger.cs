using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AnimalHunger : MonoBehaviour
{
    public Slider hungerSilder;
    public int amountToBeFed;
    private int currentFedAmount = 0;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        hungerSilder.maxValue = amountToBeFed;
        hungerSilder.value = 0;
        hungerSilder.fillRect.gameObject.SetActive(false);

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount;
        hungerSilder.fillRect.gameObject.SetActive(true);
        hungerSilder.value = currentFedAmount;

        if(currentFedAmount >= amountToBeFed)
        {
           //gameManager.AddScore(amountToBeFed);
            Destroy(gameObject, 0.1f);
        }
    }
}

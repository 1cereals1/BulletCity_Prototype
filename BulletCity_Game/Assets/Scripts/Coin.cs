using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            PlayerManager.numberofcoins+=1;
            PlayerPrefs.SetInt("NumberOfCoins", PlayerManager.numberofcoins);
            Destroy(gameObject);
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

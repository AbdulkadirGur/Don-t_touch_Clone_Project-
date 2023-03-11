using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombScript : MonoBehaviour
{
    float power;
    

    GameObject gamemanager;
    private void Start()
    {
        power = 20;
        gamemanager = GameObject.FindWithTag("GameManagerTag");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("midboxTag"))
        {
            collision.gameObject.GetComponent<midboxScript>().Damage(power); // Damage the boxes  .

            gamemanager.GetComponent<gameManager>().Create_Sound_and_Effect(0,collision.gameObject);

            
            Destroy(gameObject,5f );
            //GetComponent<CircleCollider2D>().isTrigger = false; // 
        }
    }
}

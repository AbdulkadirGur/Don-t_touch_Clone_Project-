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

            gamemanager.GetComponent<gameManager>().Create_Sound_and_Effect(0,collision.gameObject);// Effect


            Destroy(gameObject);
            //GetComponent<CircleCollider2D>().isTrigger = false; // 
        }
        if (collision.gameObject.CompareTag("Gamer2Tag"))
        {
            gamemanager.GetComponent<gameManager>().Damage_Manager(0,power); // Damage the Gamer2  .

            gamemanager.GetComponent<gameManager>().Create_Sound_and_Effect(0, collision.gameObject);// Effect

            Destroy(gameObject);
            //GetComponent<CircleCollider2D>().isTrigger = false; // 
        }
        if (collision.gameObject.CompareTag("Gamer1Tag"))
        {
            gamemanager.GetComponent<gameManager>().Damage_Manager(1, power);// Damage the Gamer1  .

            gamemanager.GetComponent<gameManager>().Create_Sound_and_Effect(0, collision.gameObject); // Effect

            Destroy(gameObject);
            //GetComponent<CircleCollider2D>().isTrigger = false; // 
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombScript : MonoBehaviour
{
    float power;
    

    GameObject gamemanager;
    GameObject Player;
    private void Start()
    {
        power = 20;
        gamemanager = GameObject.FindWithTag("GameManagerTag");
        Player = GameObject.FindWithTag("player1");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("midboxTag"))
        {

            collision.gameObject.GetComponent<midboxScript>().Damage(power); // Damage the boxes  .
            Player.GetComponent<Gamer>().PowerPlay();//  PlayPowerbar again.
            gamemanager.GetComponent<gameManager>().Create_Sound_and_Effect(0,collision.gameObject);// Effect


            Destroy(gameObject);
            //GetComponent<CircleCollider2D>().isTrigger = false; // 
        }
        if (collision.gameObject.CompareTag("Gamer2Tag") || collision.gameObject.CompareTag("player2"))
        {
            gamemanager.GetComponent<gameManager>().Damage_Manager(0,power); // Damage the Gamer2  .
            Player.GetComponent<Gamer>().PowerPlay();//  PlayPowerbar again.
            gamemanager.GetComponent<gameManager>().Create_Sound_and_Effect(0, collision.gameObject);// Effect

            Destroy(gameObject);
            
        }
        if (collision.gameObject.CompareTag("Gamer1Tag") || collision.gameObject.CompareTag("player1"))
        {
            gamemanager.GetComponent<gameManager>().Damage_Manager(1, power);// Damage the Gamer1  .
            Player.GetComponent<Gamer>().PowerPlay();//  PlayPowerbar again.
            gamemanager.GetComponent<gameManager>().Create_Sound_and_Effect(0, collision.gameObject); // Effect

            Destroy(gameObject);
            
        }

        if (collision.gameObject.CompareTag("ground"))
        {
            gamemanager.GetComponent<gameManager>().Create_Sound_and_Effect(0, collision.gameObject); // Effect
            Player.GetComponent<Gamer>().PowerPlay();//  PlayPowerbar again.
            Destroy(gameObject);

        }
    }
}

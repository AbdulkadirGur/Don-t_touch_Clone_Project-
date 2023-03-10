using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombScript : MonoBehaviour
{
    float power;
   
    private void Start()
    {
        power = 20;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("midboxTag"))
        {
            collision.gameObject.GetComponent<midboxScript>().Damage(power); // Damage the boxes  .
            Destroy(gameObject);
            //GetComponent<CircleCollider2D>().isTrigger = false; // 
        }
    }
}

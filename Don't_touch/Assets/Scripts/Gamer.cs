using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamer : MonoBehaviour
{
    public GameObject bomb;
    public GameObject bombSpawn;
    
    void Start()
    {
        
    }

    
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            GameObject bombs = Instantiate(bomb ,bombSpawn.transform.position, bombSpawn.transform.rotation);// create the bombs
            Rigidbody2D rg = bombs.GetComponent<Rigidbody2D>();
            rg.AddForce(new Vector2(2f, 0f) * 8f, ForceMode2D.Impulse); // apply force to bombs




        }
        
    }
}

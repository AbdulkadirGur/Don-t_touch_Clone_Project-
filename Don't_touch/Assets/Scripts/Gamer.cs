using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamer : MonoBehaviour
{
    public GameObject bomb;
    public GameObject bombSpawn;
    public ParticleSystem bombEffect;
    public AudioSource bombSound;

    public Image PowerBar;
    float powerNum;

    bool finishflag=false;

    Coroutine powerLoop;

    void Start()
    {
        powerLoop = StartCoroutine(PowerBarWork());
    }

    IEnumerator PowerBarWork()
    {
        finishflag = false;
        PowerBar.fillAmount = 0;

        while (true )
        {
            if (PowerBar.fillAmount < 1 && !finishflag)
            {
                powerNum = 0.01f;
                PowerBar.fillAmount += powerNum;
                yield return new WaitForSeconds(0.1f * Time.deltaTime);
            }
            else
            {
                powerNum = 0.01f;
                finishflag = true;
                PowerBar.fillAmount -= powerNum;
                yield return new WaitForSeconds(0.1f * Time.deltaTime);

                if (PowerBar.fillAmount==0)
                {
                    finishflag = false;  
                }
               
            }         
            
        }
    }
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            
            Instantiate(bombEffect, bombSpawn.transform.position, bombSpawn.transform.rotation);
            bombSound.Play();
            GameObject bombs = Instantiate(bomb ,bombSpawn.transform.position, bombSpawn.transform.rotation);// create the bombs
            Rigidbody2D rg = bombs.GetComponent<Rigidbody2D>();
            rg.AddForce(new Vector2(2f, 0f) * PowerBar.fillAmount * 12f, ForceMode2D.Impulse); // apply force to bombs

            StopCoroutine(powerLoop);
            
         

        }
       

    }

    public void PowerPlay()
    {

        powerLoop = StartCoroutine(PowerBarWork());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameManager : MonoBehaviour
{
    [Header("HEALTHBAR SETTINGS")]
    public Image player1_healthbar;
    float player1_health = 100;
    public Image player2_healthbar;
    float player2_health = 100;

    [Header("BOMB SETTINGS")]
    public ParticleSystem bombDiedEffect;
    public AudioSource bombDiedSound;
    [Header("MIDBOX SETTINGS")]
    public ParticleSystem boxDiedEffect;
    public AudioSource boxDiedSound;

   
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void Create_Sound_and_Effect(int flag ,GameObject objeTransform)
    {
        switch (flag)
        {
            case 0:
                Instantiate(bombDiedEffect, objeTransform.gameObject.transform.position, objeTransform.gameObject.transform.rotation);
                bombDiedSound.Play();
                break; 
            case 1:
                Instantiate(boxDiedEffect, objeTransform.gameObject.transform.position, objeTransform.gameObject.transform.rotation);
                boxDiedSound.Play();
                break;
        }

        
    }


    public void Damage_Manager(int flag, float damagePower)
    {
        switch (flag)
        {
            case 0:
                player2_health -= damagePower;  // Decrease the value of health.

                player2_healthbar.fillAmount = player2_health / 100;

                if (player2_health <= 0)
                {
                    Debug.Log("OYUNCU2 oldu");
                   
                }
                break;
            case 1:
                player1_health -= damagePower;  // Decrease the value of health.

                player1_healthbar.fillAmount = player1_health / 100;

                if (player1_health <= 0)
                {
                    Debug.Log("OYUNCU1 oldu");

                }

                break;
        }


    }
}

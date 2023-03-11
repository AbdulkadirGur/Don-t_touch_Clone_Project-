using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
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
    
}

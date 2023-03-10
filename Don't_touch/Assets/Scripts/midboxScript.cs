using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class midboxScript : MonoBehaviour
{
    public GameObject healthCanvas;
    float health = 100 ;
    public Image healthBar;
    


   public void Damage(float damageForce)
    {
        health -= damageForce;  // Decrease the value of health.

        healthBar.fillAmount = health / 100;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            StartCoroutine(openHealthBar()); // Open the healthbar after the damage
        }     
    }

    IEnumerator openHealthBar()
    {
        if (!healthCanvas.activeInHierarchy)
        {
            healthCanvas.SetActive(true);
            yield return new WaitForSeconds(2);
            healthCanvas.SetActive(false);
        }
        
    }
}

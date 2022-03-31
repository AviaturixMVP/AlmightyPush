using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float startHealth = 100;
    private float health;
    [Header("Unity Stuff")]
    public Image Healthbar;

    private void Start()
    {
        health = startHealth;
    }
    public void TakeDamage(float damage)
    {
        if (health > 0)
        {
            health -= damage;

            Healthbar.fillAmount = health / startHealth;
        }
        else
        {
            //Invoke("DestroyEnemy", 0.1f);
            Destroy(gameObject);
        }
        
    }
    
   // void DestroyEnemy()
    //{
     //   Destroy(gameObject);
    //}
}

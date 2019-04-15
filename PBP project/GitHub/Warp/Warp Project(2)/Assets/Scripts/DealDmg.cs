using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script made by Lucas Newton

public class DealDmg : MonoBehaviour {

    public static int currentHealth = 100;
    public GameObject Enemy;
    public GameObject player;
    
    //only assign this object if this component is to be applied to an object that will be a boss
    public GameObject passage;

    //this method allows for the enemies to take damage
    public void TakeDamage(int amt)
    {
        currentHealth -= amt;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Enemy Destroyed");
            Destroy(Enemy);

            //this should only occur when defeating a boss
            if (Enemy.tag == "Boss")
            {
                Destroy(passage);
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("the enemies health : " + currentHealth);
        }
    }
}

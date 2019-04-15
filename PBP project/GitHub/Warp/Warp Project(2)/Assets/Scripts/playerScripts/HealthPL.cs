using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

//Script made by Lucas Newton


[System.Serializable]
public class HealthPL : MonoBehaviour{

    public RectTransform healthbar;
    public static int currentHealth = 100;
    public GameObject player;
    public bool Invincible = false;
    public static int lvl = 1;

    //this method allows the player to gain health if the object that they collide with has an "hpOrb" tag
    public void OnTriggerEnter2D(Collider2D item)
    {
        if(item.gameObject.tag == "hpOrb")
        {
            
            currentHealth += 25;
            if(currentHealth > 100)
            {
                currentHealth = 100;
            }
            Debug.Log("here is your current health : " + currentHealth);
            Destroy(item.gameObject);
            
        }

        healthbar.sizeDelta = new Vector2(currentHealth, healthbar.sizeDelta.y);
    }


    //this method allows the players health to decrement from the amt while the players currentHealth is greater than 0.
    public void TakeDamage(int amt)
    {
        currentHealth -= amt;
        Debug.Log("here is your current health : " + currentHealth);
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("you lost");
            Destroy(player);
        }

        //this allows the health bar to move based on what the players health is.
        healthbar.sizeDelta = new Vector2(currentHealth, healthbar.sizeDelta.y); 
    }

    //This method detects if the player collides with a enemy taged object and the player takes damage and becomes invulnerable for a short period of time
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!Invincible)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                if(currentHealth > 0)
                {
                    TakeDamage(10);
                    Invincible = true;
                    Invoke("ResetInvulnerability", 2);
                }
                else if(player != null)
                {
                    Destroy(player);
                }
            }
            else if(collision.gameObject.tag == "Boss")
            {
                if (currentHealth > 0)
                {
                    TakeDamage(95);
                    Invincible = true;
                    Invoke("ResetInvulnerability", 2);
                }
                else if (player != null)
                {
                    Destroy(player);
                }
            }
            else if(collision.gameObject.tag == "spike")
            {
                if(currentHealth > 0)
                TakeDamage(currentHealth);
                else if(player != null)
                {
                    Destroy(player);
                }
                
            }
        }
    }

    //this method allows the invincibility to ware off and be able to become true again
    void ResetInvulnerability()
    {
        Invincible = false;
    }




    //this method saves the player object using the savePlayer function in the SaveSystem class

    //public static int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    public void Save()
    {
        SaveSystem.savePlayer(this);
        Debug.Log("save runs");
    }

    //this method loads the player to where the player was and the players health at the time the save function was executed
    public void Load()
    {
        Debug.Log("load runs");
        PlayerData data = SaveSystem.loadPlayer();

        lvl = data.level;
        currentHealth = data.health;
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
        
        //SceneManager.LoadScene(currentSceneIndex);

        healthbar.sizeDelta = new Vector2(currentHealth, healthbar.sizeDelta.y);
    }

    public void Delete()
    {
        SaveSystem.DeleteSave();
    }

    //this built in method might help to save between scenes
    /*
    public void OnLevelWasLoaded(int level)
    {
        
    }
    */

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

    }
}

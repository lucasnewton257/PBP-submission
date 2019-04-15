using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPL : MonoBehaviour {

    // Use this for initialization
    public GameObject HealthMenuUi;
    public const int maxHealth = 100;
    public int currentHealth = maxHealth;
    public GameObject player;

    public void TakeDamage(int amt)
    {
        currentHealth -= amt;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("you lost");
        }
        HealthMenuUi.GetComponent<Scrollbar>().size = currentHealth / 100;
    }

    //this might work
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("this is called");

        if (currentHealth > 0)
        {
            TakeDamage(5);
            WaitDamage();
        }
        else
        {
            Destroy(player);
        }
    }

    IEnumerator WaitDamage()
    {
        yield return new WaitForSecondsRealtime(50);
    }
}

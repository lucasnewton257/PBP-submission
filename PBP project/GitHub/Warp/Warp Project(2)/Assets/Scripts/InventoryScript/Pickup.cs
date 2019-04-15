using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    private Inventory inventory;
    public GameObject itemButton;
    public int i = 0;

    private void Start()
    {
        itemButton.SetActive(false);
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    //this method will check to see if the inventory is full when the player collides witht the object and will make a new object to put in the inventory slots if the inventory is not full
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    itemButton.SetActive(true);
                    Instantiate(itemButton, inventory.slots[i].transform, false); // spawn the button so that the player can interact with it
                    Destroy(itemButton);
                    Debug.Log("The object was instantiated!");
                    Destroy(gameObject);
                    break;
                }
            }
        }

    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Catalog : MonoBehaviour
{

    /*
    public bool isFull = false;
    public GameObject[] invent;
    public Button[] buttons;


    //this method will set the spot of an array equal to the object with the tag if the spot is not filled already
    //method still in progress
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isFull)
        {
            if (collision.gameObject.tag.Equals("Weapon"))
            {
                for (int i = 0; i < invent.Length; i++)
                {
                    if (invent[i] == null)
                    {
                        invent[i] = collision.gameObject;

                        Debug.Log("Weapon adde to arsenal!");
                        Destroy(collision.gameObject);
                        break;
                    }
                    if(invent[invent.Length-1] != null)
                    {
                        isFull = true;
                        Debug.Log("Your inventory is full!");
                        break;
                    }
                }
            }
        }
    }


    public void removeItem()
    {
        for(int i = 0; i<buttons.Length; i++)
        {
            if(invent[i] != null)
            {
                Destroy(invent[i].gameObject);
            }
        }
    }
    */
}

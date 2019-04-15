using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//script made by Lucas Newton

public class PickUpGems : MonoBehaviour {
    private int gems = 0;
    public GameObject gem;
    public Text Score;

    //this method will display the amount of gems the player has
    public void Update()
    {
        Score.text = " : "+ gems;
    }


    //this method allows for the gems to be picked up and the gems amount to be increased
    public void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.gameObject.tag.Equals("Gem"))
            {
                gems += 1;
                Destroy(collision.gameObject);
            }
    }
}

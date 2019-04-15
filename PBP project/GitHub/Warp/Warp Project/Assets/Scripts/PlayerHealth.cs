using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    int health = 8;
    bool playerHit = false;

    // Use this for initialization
    private void OnTriggerEnter(Collision2D collission)
    {
        playerHit = true;
    }

}
	
	// Update is called once per frame
	public void Update ()
    {
	    if (OntriggerEnter)
        {
            health = 0;
        }

        if(health == 0)
        {
            
        }
	}
}

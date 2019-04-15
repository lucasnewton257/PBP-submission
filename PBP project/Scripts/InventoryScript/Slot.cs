using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour {

    
    private Inventory inventory;
    public int index;

    private void Start()
    {
        
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
        if (transform.childCount <= 0) 
            inventory.isFull[index] = true;
    }

    public void DropItem() {

        foreach (Transform child in transform) {
            child.GetComponent<Spawn>().SpawnItem();
            Destroy(child.gameObject);
        }
    }
    

}

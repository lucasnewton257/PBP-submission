using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {


    public bool[] isFull;
    public GameObject[] slots;
    public bool shockSwordEquipped;

    public void Start()
    {
        shockSwordEquipped = false;
    }

    public void Update()
    {
        EquipShockSword();
    }


    public bool EquipShockSword()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (isFull[0] == true)
            {
                Debug.Log("shock sword equipped");
                return true;
            }
            else
                Debug.Log("there is no item in your inventory");
                return false;
        }
        else
            return false;
    }
    
}

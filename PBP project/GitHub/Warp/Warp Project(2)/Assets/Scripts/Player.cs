using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [System.Serializable]
    public class PlayerStats{
        public int Health = 100;
        public int gems = 0;
        public int level = 1;
}

    public RespawnMenu rMenu;
    public PlayerStats playerStats = new PlayerStats();
    public int fallBoundary = -40;
    public static GameMaster GM;
    private void Start()
    {
        if (GM == null)
            GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }
    private void Update()
    {
        if(transform.position.y <= fallBoundary)
        {
            GameMaster.KillPlayer(this);
        } 
    }

    public void DamagePlayer(int dmg)
    {
        playerStats.Health -= dmg;
        Debug.Log("Your current health is " + playerStats.Health);
        if(playerStats.Health <= 0)
        {
            GameMaster.KillPlayer(this);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
            DamagePlayer(10);
        if (collision.gameObject.tag == "Gem")
        {
            playerStats.gems += 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "CheckPoint")
            GM.CheckPointReached = true;
    }

    public void IncreasePlayerGems(int x)
    {
        playerStats.gems += x;
    }

    public void DecreasePlayerGems(int x)
    {
        playerStats.gems -= x;
    }
}

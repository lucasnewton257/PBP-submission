using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

    public static GameMaster gm;
    public Transform Checkpoint;
    public void Start()
    {
     if (gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>() ;
        }
        if (CheckPointReached)
        {
            Instantiate(playerPrefab, Checkpoint.position, Checkpoint.rotation);
        }
        else
            Instantiate(playerPrefab, Checkpoint.position, Checkpoint.rotation);
    }

    public GameObject playerPrefab;
    public Transform spawnPoint;
    public int spawnDelay = 1;

    [HideInInspector]
    public bool CheckPointReached;
    public void RespawnPlayer()
    {
        if (CheckPointReached) //checks to see if checkpoint is reached, if so respawn at checkpoint position
            Instantiate(playerPrefab, Checkpoint.position, Checkpoint.rotation);
        else
            Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        Time.timeScale = 1;
    }

    public static void KillPlayer(Player player)
    {
        if(player != null)
            Destroy(player.gameObject);
        SceneManager.LoadScene(1);
    }

    public static void KillEnemy( Enemy enemy)
    {
        if(enemy != null)
            Destroy(enemy.gameObject);
    }
    
}

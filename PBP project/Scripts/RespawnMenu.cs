using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnMenu : MonoBehaviour
{
    public static GameMaster GM;
    private void Start()
    {
        if (GM == null)
            GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    public void RespawnPlayer()
    {
        SceneManager.LoadScene(2);
    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Save(HealthPL player)
    {
        SaveSystem.savePlayer(player);
        Debug.Log("save runs");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    //this method loads the player to where the player was and the players health at the time the save function was executed

    public void Load()
    {
        Debug.Log("load runs");
        PlayerData data = SaveSystem.loadPlayer();

        //lvl = data.level;
        HealthPL.currentHealth = data.health;
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;

        //SceneManager.LoadScene(currentSceneIndex);

        //healthbar.sizeDelta = new Vector2(currentHealth, healthbar.sizeDelta.y);
    }
}

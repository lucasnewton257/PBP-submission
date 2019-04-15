using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PlayerData {


    public int health;
    public int level;
    public float[] position;
    
    public PlayerData(HealthPL player)
    {
        health = HealthPL.currentHealth;
        //level = HealthPL.currentSceneIndex;
        level = HealthPL.lvl;

        //using a float array is a way to stroe vector positions
        position = new float[3];

        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }

}

//still a class in progress
[System.Serializable]
public class EnemyData
{
    public int health;
    public float[] position;

    public EnemyData(DealDmg enemy)
    {
        health = DealDmg.currentHealth;

        position = new float[3];

        position[0] = enemy.transform.position.x;
        position[1] = enemy.transform.position.y;
        position[2] = enemy.transform.position.z;
    }
}


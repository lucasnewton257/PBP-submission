using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    // Use this for initialization
    [System.Serializable]
    public class EnemyStats
    {
        public int Health = 100;
    }

    public EnemyStats stats = new EnemyStats();
    public int fallBoundary = -40;

    public void DamageEnemy(int dmg)
    {
        stats.Health -= dmg;
        if (stats.Health <= 0)
        {
            GameMaster.KillEnemy(this);
        }
    }
}

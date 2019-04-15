using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public LayerMask isEnemy;
    public LayerMask isBoss;
    public float attackRange;
    public int damage;

    public void Start()
    {
        
    }



    // This method sets up the time attack value and puts all of the enemies and bosses to be stored in an array and be dealt damage
    void Update () {
        if(timeBtwAttack <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
               //if ()
                //{
                    Collider2D[] hurtEnemies = Physics2D.OverlapCircleAll(attackPos.position, attackRange, isEnemy | isBoss);
                    for (int i = 0; i < hurtEnemies.Length; i++)
                    {
                        hurtEnemies[i].GetComponent<DealDmg>().TakeDamage(damage);
                    }
                    timeBtwAttack = startTimeBtwAttack;
                //}
            }

        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
		
	}

    //this method gives the cirlce the color red and the arguments to be set
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }

}

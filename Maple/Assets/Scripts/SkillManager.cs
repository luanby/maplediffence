using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class SkillManager : MonoBehaviour
{
    public float damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
            Enemysnail enemy = collision.gameObject.GetComponent<Enemysnail>();
        if (enemy.enemyState != Enemysnail.EnemyState.Die)
            enemy.Hurt(damage);


               
            
        
        
    }


}

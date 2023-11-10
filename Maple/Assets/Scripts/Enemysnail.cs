using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemysnail : MonoBehaviour
{
    public GameObject enemy;


    public float speed;
    public float bounsespeed;

    public GameObject player ;

    public Slider lifeBar;
    public EnemyState enemyState;
    private AudioSource audiosrc;
    public Animator anim;
    public AudioClip hitSound;
    public AudioClip deadSound;

    public float damage;
    public float mobExp;
    
   



    public float hp;
    public float maxHp;
    public enum EnemyState
    {
        Idle,
        Move,
        Attack,
        Hurt,
        Die,


    }

    private void Update()
    {
        Vector3 dir = Vector3.left;
        anim.SetBool("move",true);
        transform.position += dir * speed * Time.deltaTime;
        //transform.position = Vector3.Lerp(transform.position, tower.position, speed * Time.deltaTime);
    }

   
  
    public void Hurt(float damage)
    {
        if (hp > 0)
        {

            enemyState = EnemyState.Hurt;
            
           
            anim.SetTrigger("hit");
            



            hp -= damage;
            lifeBar.value = hp / maxHp;

            
           

            
        }
       

        if (hp <= 0)
        {
            Death();
            

        }
    }
    public void Death()
    {
        enemyState = EnemyState.Die;
        anim.SetBool("move", false);
        anim.SetTrigger("die");
        speed = 0f;
        Player pc = player.GetComponent<Player>();
        pc.GetExp(mobExp);




    }

    public void Destroymob()
    {

        

        Destroy(gameObject);


    }

    
    
}

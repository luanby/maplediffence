using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;


public class Player : MonoBehaviour
{

    public enum PlayerState
    {
        Idle,
        Walk,
        Attack,
        Dead,
       
    }
    public float speed;
    private Animator animator;
    public PlayerState playerState;
    public GameObject attack;
    public float damage; 
    public Slider lifeBar;
    public float maxHp;
    public float hp;
    private float exp;
    private float maxexp;
    public float level;


    private void Start()
    {
        
        attack.SetActive(false);
        animator = GetComponent<Animator>();
        level = 1;
        exp = 0;
        maxexp = 100;

        
    }
    private void Update()
    {
        
        Wark();
        Attack();
        

    }



    private void Wark()
    {
        
        float move = Input.GetAxis("Horizontal");
        Vector3 dir = new Vector3(move, 0);
        





        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            transform.Translate(dir * -speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            animator.SetBool("Walk", true);
        }
        else if (Input.GetKey("left") || Input.GetKey("a"))
        {
            transform.Translate(dir * speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            animator.SetBool("Walk", true);
        }

        else
            animator.SetBool("Walk", false);


    }

    private void Attack()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {

            animator.SetTrigger("attack");
           
           
        }
        
        
    }

    public void AttackrangeOn()
    {
        
        attack.SetActive(true);
    }  

    public void AttackrangeOff()
    {
        attack.SetActive(false);
    }
    public void Hurt(float damage)
    {
        if (hp > 0)
        {
            hp -= damage;
            lifeBar.value = hp / maxHp;
        }

        if (hp <= 0)
        {
            speed = 0;
            playerState = PlayerState.Dead;
        }
    }

    public void GetExp(float getexp)
    {

      
        exp += getexp;
        Debug.Log("A");

        if(exp >= maxexp)
        {
            LevelUp();
        }
    }

    public void LevelUp()
    {
        level++;
        exp -= maxexp;

        maxexp = maxexp * 2;
    }

  
   
}

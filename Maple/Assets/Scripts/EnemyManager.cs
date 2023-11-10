using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class EnemyManager : MonoBehaviour


{

  
    private float speed;
   
    public GameObject monster;



    public float spawnSecon = 2.0f;


    private void Start()
    {

        StartCoroutine(Enemy1Spawn());


    }
   


   

   
    private IEnumerator Enemy1Spawn()
    {

        while (true)
        {
            GameObject enemy1Spawn = Instantiate(monster, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnSecon);
            
        }
    }
    


}

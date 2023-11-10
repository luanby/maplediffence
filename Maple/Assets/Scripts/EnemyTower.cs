using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject enemyTowerHp;
    private GameObject enemyTower;
    private void Start()
    {
        // Canvas에서 HP 슬라이더를 찾습니다.
        enemyTowerHp = GameObject.Find("Canvas/EnemyTowerHP");
        

        if (enemyTowerHp != null)
        {
            // 이 GameObject의 월드 좌표를 가져옵니다.
            Vector3 objectPosition = transform.position;

            // 월드 좌표를 화면 좌표로 변환합니다.
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(objectPosition);

            // 화면 좌표에 (0, 1, 0) 벡터를 더합니다.
            screenPosition += new Vector3(20, 120, 0);

            // Canvas 내 HP 슬라이더의 위치를 화면 좌표로 설정합니다.
            enemyTowerHp.transform.position = screenPosition;
        }
        else
        {
            enemyTowerHp.SetActive(false);
        }
    }
}


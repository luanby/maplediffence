using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject enemyTowerHp;
    private GameObject enemyTower;
    private void Start()
    {
        // Canvas���� HP �����̴��� ã���ϴ�.
        enemyTowerHp = GameObject.Find("Canvas/EnemyTowerHP");
        

        if (enemyTowerHp != null)
        {
            // �� GameObject�� ���� ��ǥ�� �����ɴϴ�.
            Vector3 objectPosition = transform.position;

            // ���� ��ǥ�� ȭ�� ��ǥ�� ��ȯ�մϴ�.
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(objectPosition);

            // ȭ�� ��ǥ�� (0, 1, 0) ���͸� ���մϴ�.
            screenPosition += new Vector3(20, 120, 0);

            // Canvas �� HP �����̴��� ��ġ�� ȭ�� ��ǥ�� �����մϴ�.
            enemyTowerHp.transform.position = screenPosition;
        }
        else
        {
            enemyTowerHp.SetActive(false);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    private float enemyTowerHp; //�� Ÿ�� ���� HP
    public float enemyTowermaxHp; //��Ÿ���� �ִ� HP                  
    public void SetHp(float amount) //*Hp����
    {
        enemyTowermaxHp = amount;
        enemyTowerHp = enemyTowermaxHp;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Stage");
    }

    public Slider enemyTowerHpslider;
    public void CheckHp() //*HP ����
    {
        if (enemyTowerHpslider != null)
            enemyTowerHpslider.value = enemyTowerHp / enemyTowermaxHp;
    }
    public void Damage(float damage) //* ������ �޴� �Լ�
    {
        if (enemyTowermaxHp == 0 || enemyTowerHp <= 0) //* �̹� ü�� 0���ϸ� �н�
            return;

        enemyTowermaxHp -= damage;
        CheckHp(); //* ü�� ����
        if (enemyTowerHp <= 0)
        {
            //* ü���� 0 ���϶� ����
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    private float enemyTowerHp; //적 타워 현재 HP
    public float enemyTowermaxHp; //적타워의 최대 HP                  
    public void SetHp(float amount) //*Hp설정
    {
        enemyTowermaxHp = amount;
        enemyTowerHp = enemyTowermaxHp;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Stage");
    }

    public Slider enemyTowerHpslider;
    public void CheckHp() //*HP 갱신
    {
        if (enemyTowerHpslider != null)
            enemyTowerHpslider.value = enemyTowerHp / enemyTowermaxHp;
    }
    public void Damage(float damage) //* 데미지 받는 함수
    {
        if (enemyTowermaxHp == 0 || enemyTowerHp <= 0) //* 이미 체력 0이하면 패스
            return;

        enemyTowermaxHp -= damage;
        CheckHp(); //* 체력 갱신
        if (enemyTowerHp <= 0)
        {
            //* 체력이 0 이하라 죽음
        }
    }
}

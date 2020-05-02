using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour //Управление интерфейсом
{
    public Text THealth,TScore,TNeedScore;
    [HideInInspector]public int Health, Score, NeedScore;
    private int a;

    public void Start()
    {
        a = PlayerPrefs.GetInt("GlobalScore");
        Health = 3;
        Score = 0;
        NeedScore = PlayerPrefs.GetInt("NeedScore");
        TNeedScore.text = "NeedScore: " + NeedScore;
        THealth.text = "Health: " + Health;
        TScore.text = "Score: " + Score;
    }

    public void PlayerDamaged()
    {
        Health--;
        if (Health <= 0)
        {
            LoosePlayer();
        }
        THealth.text = "Health: " + Health;
    }

    public void EnemyKilled()
    {
        Score++;
        TScore.text = "Health: " + Score;
        if (Score >= NeedScore)
        {
            PlayerPrefs.SetInt("GlobalScore", a+Score);
            SceneManager.LoadScene("Menu");
        }
    }

    void LoosePlayer()
    {
        PlayerPrefs.SetInt("GlobalScore", a+Score);
        SceneManager.LoadScene("Menu");
    }
}

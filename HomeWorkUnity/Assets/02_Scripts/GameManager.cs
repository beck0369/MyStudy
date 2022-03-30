using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool isGameover = false;
    public Text scoreText;
    public GameObject menuPanel;

    public int hpCount = 3;
    public Text hpText;

    private int score = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("씬에 두개 이상의 게임 매니저가 존재합니다.");
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        hpText.text = hpCount.ToString();
    }
    public void AddScore(int newScore)
    {
        if (!isGameover)
        {
            score += newScore;
            scoreText.text = "score : " + score;
        }
    }

    public void OnPlayerDead()
    {
        isGameover = true;
        menuPanel.SetActive(true);
    }


    public bool Damage()
    {
        hpText.text = "" + --hpCount;
        return hpCount <= 0 ? true : false;
    }

}

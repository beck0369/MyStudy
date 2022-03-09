using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverText; // ���ӿ��� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
    public Text timeText;   // ���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recordText; // �ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ

    private float surviveTime;  // ���� �ð�
    private bool isGameover;    // ���ӿ��� ����

    private void Start()
    {
        surviveTime = 0;
        isGameover = false; // ���� �ð��� ���ӿ��� ���� �ʱ�ȭ
    }

    private void Update()
    {
        if (!isGameover)    // ���ӿ����� �ƴ� ����
        {
            surviveTime += Time.deltaTime;  // ���� �ð� ����
            timeText.text = "Time : " + (int)surviveTime;   // ������ ���� �ð��� timeText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void EndGame()
    {
        isGameover = true;  // ���� ���¸� ���ӿ��� ���·� ��ȯ
        gameOverText.SetActive(true);   // ���ӿ��� �ؽ�Ʈ ���� ������Ʈ�� Ȱ��ȭ

        float bestTime = PlayerPrefs.GetFloat("BestTime");  // BestTime Ű�� ����� ���������� �ְ� ��� ��������

        if (surviveTime > bestTime) // ���������� �ְ� ��Ϻ��� ���� ���� �ð��� �� ũ�ٸ�
        {
            bestTime = surviveTime; // �ְ� ��� ���� ���� ���� �ð� ������ ����
            PlayerPrefs.SetFloat("BestTime", bestTime); // ����� �ְ� ����� BestTime Ű�� ����
        }

        recordText.text = "Best Time : " + (int)bestTime;   // �ְ� ����� recordText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
    }
}

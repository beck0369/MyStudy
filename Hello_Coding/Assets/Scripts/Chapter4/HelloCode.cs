using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    //private void Start()
    //{
    //    // Hello World!�� �ֿܼ� ���
    //    Debug.Log("Hello World!");
    //}


    //private void Start()
    //{
    //    // ĳ������ �������� ������ �����
    //    string chareacterName = "���";
    //    char bloodType = 'A';
    //    int age = 17;
    //    float height = 168.3f;
    //    bool isFemale = true;

    //    // ������ ������ �ֿܼ� ���
    //    Debug.Log("ĳ���� �̸� : " + chareacterName);
    //    Debug.Log("������ : " + bloodType);
    //    Debug.Log("���� : " + age);
    //    Debug.Log("Ű : " + height);
    //    Debug.Log("�����ΰ�? : " + isFemale);
    //}


    //private void Start()
    //{
    //    float distance = GetDistance(2, 2, 5, 6);
    //    Debug.Log("(2, 2)���� (5, 6)������ �Ÿ� : " + distance);
    //}

    //float GetDistance(float x1, float y1, float x2, float y2)
    //{
    //    float width = x2 - x1;
    //    float height = y2 - y1;

    //    float distance = width * width + height * height;
    //    distance = Mathf.Sqrt(distance);

    //    return distance;
    //}


    //private void Start()
    //{
    //    int love = 80;

    //    if (love > 90)
    //    {
    //        // love�� 90���� ū ���
    //        Debug.Log("Ʈ�翣�� : �����ΰ� ��ȥ�ߴ�.");
    //    }

    //    else if (love > 70)
    //    {
    //        // love�� 90���� �۰ų� ����, 70���� ū ���
    //        Debug.Log("�¿��� : �����ΰ� ��Ͱ� �Ǿ���!");
    //    }

    //    else
    //    {
    //        // love�� 70���� �۰ų� ���� ���
    //        Debug.Log("��忣�� : �����ο��� ������.");
    //    }
    //}


    //private void Start()
    //{
    //    int age = 11;

    //    if (age > 7 && age < 18)
    //    {
    //        Debug.Log("�ǹ� ������ �ް� �ֽ��ϴ�.");
    //    }

    //    if (age < 13 || age > 70) 
    //    {
    //        Debug.Log("���� �� �� ���� �����Դϴ�.");
    //    }
    //}


    //private void Start()
    //{
    //    for (int i = 0; i < 10; i++)
    //    {
    //        Debug.Log(i + " ��° �����Դϴ�.");
    //    }
    //}


    //private void Start()
    //{
    //    int i = 0;

    //    while (i < 10)
    //    {
    //        Debug.Log(i + " ��° �����Դϴ�.");
    //        i++;
    //    }
    //}


    private void Start()
    {
        bool isDead = false;
        int hp = 100;

        while (!isDead)
        {
            Debug.Log("���� ü�� : " + hp);

            hp = hp - 33;

            if (hp <= 0)
            {
                isDead = true;
                Debug.Log("�÷��̾�� �׾����ϴ�.");
            }
        }
    }
}

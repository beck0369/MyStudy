using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    //private void Start()
    //{
    //    // Hello World!를 콘솔에 출력
    //    Debug.Log("Hello World!");
    //}


    //private void Start()
    //{
    //    // 캐릭터의 프로필을 변수로 만들기
    //    string chareacterName = "라라";
    //    char bloodType = 'A';
    //    int age = 17;
    //    float height = 168.3f;
    //    bool isFemale = true;

    //    // 생성한 변수를 콘솔에 출력
    //    Debug.Log("캐릭터 이름 : " + chareacterName);
    //    Debug.Log("혈액형 : " + bloodType);
    //    Debug.Log("나이 : " + age);
    //    Debug.Log("키 : " + height);
    //    Debug.Log("여성인가? : " + isFemale);
    //}


    //private void Start()
    //{
    //    float distance = GetDistance(2, 2, 5, 6);
    //    Debug.Log("(2, 2)에서 (5, 6)까지의 거리 : " + distance);
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
    //        // love가 90보다 큰 경우
    //        Debug.Log("트루엔딩 : 히로인과 결혼했다.");
    //    }

    //    else if (love > 70)
    //    {
    //        // love가 90보다 작거나 같고, 70보다 큰 경우
    //        Debug.Log("굿엔딩 : 히로인과 사귀게 되었다!");
    //    }

    //    else
    //    {
    //        // love가 70보다 작거나 같은 경우
    //        Debug.Log("배드엔딩 : 히로인에게 차였다.");
    //    }
    //}


    //private void Start()
    //{
    //    int age = 11;

    //    if (age > 7 && age < 18)
    //    {
    //        Debug.Log("의무 교육을 받고 있습니다.");
    //    }

    //    if (age < 13 || age > 70) 
    //    {
    //        Debug.Log("일을 할 수 없는 나이입니다.");
    //    }
    //}


    //private void Start()
    //{
    //    for (int i = 0; i < 10; i++)
    //    {
    //        Debug.Log(i + " 번째 순번입니다.");
    //    }
    //}


    //private void Start()
    //{
    //    int i = 0;

    //    while (i < 10)
    //    {
    //        Debug.Log(i + " 번째 루프입니다.");
    //        i++;
    //    }
    //}


    private void Start()
    {
        bool isDead = false;
        int hp = 100;

        while (!isDead)
        {
            Debug.Log("현재 체력 : " + hp);

            hp = hp - 33;

            if (hp <= 0)
            {
                isDead = true;
                Debug.Log("플레이어는 죽었습니다.");
            }
        }
    }
}

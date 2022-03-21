using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B4 : MonoBehaviour
{
    // 1. 변수
    int level = 5;
    float strength = 15.5f;
    string playerName = "백검사";
    bool isFullLevel = false;
    // 선언 > 초기화 > 호출
    int health = 30;

    private void Start()
    {
        Debug.Log("Hello Unity!");

        // 2. 그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        List<string> items = new List<string>();
        items.Add("빨간물약");
        items.Add("파란물약");

        items.RemoveAt(0);

        // 3. 연산자
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        int nextExp = 300 - (exp % 300);

        string title = "전설의";
        Debug.Log(title + name);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;

        bool isEndTutorial = level < 10;

        
        int mana = 25;
        //bool isBadCondition = health <= 50 && mana <= 20;
        bool isBadCondition = health <= 50 || mana <= 20;

        string condition = isBadCondition ? "나쁨" : "좋음";

        // 4. 키워드
        //int float string bool new List

        // 5. 조건문
        if (condition == "나쁨")
        {
            Debug.Log("플레이어의 상태가 나쁘다");
        }
        else
        {
            Debug.Log("플레이어의 상태가 좋다");
        }

        if (isBadCondition && items[0] == "빨간물약")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("빨간물약을 사용했다");
        }
        else if (isBadCondition && items[1] == "파란물약")
        {
            items.RemoveAt(1);
            mana += 30;
            Debug.Log("파란물약을 사용했다");
        }

        switch (monsters[1])
        {
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형 몬스터");
                break;
            case "악마":
                Debug.Log("중형 몬스터");
                break;
            case "골렘":
                Debug.Log("대형 몬스터");
                break;
            default:
                Debug.Log("??? 몬스터");
                break;
        }

        // 6. 반복문
        while (health > 0)
        {
            health--;
            if (health > 0)
            {
                Debug.Log("독 데미지를 입고 있다" + health);
            }
            else
            {
                Debug.Log("플레이어가 죽었다");
            }

            if (health == 10)
            {
                Debug.Log("해독제를 사용했다");
                break;
            }
        }

        for (int count = 0; count  < 10; count ++)
        {
            health++;
            Debug.Log("치료 중" + health);
        }

        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("현재 몬스터" + monsters[index]);
        }

        foreach (string monster in monsters)
        {
            Debug.Log("현재 몬스터" + monster);
        }

        health = Heal(health);

        Heal2();

        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("용사는" + monsters[index] + "에게" + Battle(monsterLevel[index]));
        }

        // 8. 클래스
        B4_3 player = new B4_3();
        player.id = 0;
        player.name = "백법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은" + player.level + "이다");
        Debug.Log(player.Move());
    }

    // 7. 함수 (메소드)
    int Heal(int currentHealth)
    {
        currentHealth += 10;
        Debug.Log("힐을 받았다" + currentHealth);
        return currentHealth;
    }

    void Heal2()
    {
        health += 10;
        Debug.Log("힐을 받았다" + health);
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
        {
            result = "전투에서 승리했다";
        }
        else
        {
            result = "전투에서 패배했다";
        }
        return result;
    }

    // 8. 클래스
    
    // 9. 
}

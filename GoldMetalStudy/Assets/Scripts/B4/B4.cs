using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B4 : MonoBehaviour
{
    // 1. ����
    int level = 5;
    float strength = 15.5f;
    string playerName = "��˻�";
    bool isFullLevel = false;
    // ���� > �ʱ�ȭ > ȣ��
    int health = 30;

    private void Start()
    {
        Debug.Log("Hello Unity!");

        // 2. �׷��� ����
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        List<string> items = new List<string>();
        items.Add("��������");
        items.Add("�Ķ�����");

        items.RemoveAt(0);

        // 3. ������
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        int nextExp = 300 - (exp % 300);

        string title = "������";
        Debug.Log(title + name);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;

        bool isEndTutorial = level < 10;

        
        int mana = 25;
        //bool isBadCondition = health <= 50 && mana <= 20;
        bool isBadCondition = health <= 50 || mana <= 20;

        string condition = isBadCondition ? "����" : "����";

        // 4. Ű����
        //int float string bool new List

        // 5. ���ǹ�
        if (condition == "����")
        {
            Debug.Log("�÷��̾��� ���°� ���ڴ�");
        }
        else
        {
            Debug.Log("�÷��̾��� ���°� ����");
        }

        if (isBadCondition && items[0] == "��������")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("���������� ����ߴ�");
        }
        else if (isBadCondition && items[1] == "�Ķ�����")
        {
            items.RemoveAt(1);
            mana += 30;
            Debug.Log("�Ķ������� ����ߴ�");
        }

        switch (monsters[1])
        {
            case "������":
            case "�縷��":
                Debug.Log("���� ����");
                break;
            case "�Ǹ�":
                Debug.Log("���� ����");
                break;
            case "��":
                Debug.Log("���� ����");
                break;
            default:
                Debug.Log("??? ����");
                break;
        }

        // 6. �ݺ���
        while (health > 0)
        {
            health--;
            if (health > 0)
            {
                Debug.Log("�� �������� �԰� �ִ�" + health);
            }
            else
            {
                Debug.Log("�÷��̾ �׾���");
            }

            if (health == 10)
            {
                Debug.Log("�ص����� ����ߴ�");
                break;
            }
        }

        for (int count = 0; count  < 10; count ++)
        {
            health++;
            Debug.Log("ġ�� ��" + health);
        }

        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("���� ����" + monsters[index]);
        }

        foreach (string monster in monsters)
        {
            Debug.Log("���� ����" + monster);
        }

        health = Heal(health);

        Heal2();

        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("����" + monsters[index] + "����" + Battle(monsterLevel[index]));
        }

        // 8. Ŭ����
        B4_3 player = new B4_3();
        player.id = 0;
        player.name = "�����";
        player.title = "������";
        player.strength = 2.4f;
        player.weapon = "���� ������";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "�� ������" + player.level + "�̴�");
        Debug.Log(player.Move());
    }

    // 7. �Լ� (�޼ҵ�)
    int Heal(int currentHealth)
    {
        currentHealth += 10;
        Debug.Log("���� �޾Ҵ�" + currentHealth);
        return currentHealth;
    }

    void Heal2()
    {
        health += 10;
        Debug.Log("���� �޾Ҵ�" + health);
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
        {
            result = "�������� �¸��ߴ�";
        }
        else
        {
            result = "�������� �й��ߴ�";
        }
        return result;
    }

    // 8. Ŭ����
    
    // 9. 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5 : MonoBehaviour
{
    //private void Start()
    //{
    //    string userInput = "10";

    //    int number = int.Parse(userInput);
    //    if(number < 0)
    //    {
    //        Debug.Log("����");
    //    }
    //    else if(number > 0)
    //    {
    //        Debug.Log("���");
    //    }
    //    else
    //    {
    //        Debug.Log("0");
    //    }

    //    if(number % 2 == 0)
    //    {
    //        Debug.Log("¦��");
    //    }
    //    else
    //    {
    //        Debug.Log("Ȧ��");
    //    }
    //}   �� : ���  ¦��


    //private void Start()
    //{
    //    string userInput = "10";

    //    int number = int.Parse(userInput);
    //    if(number > 0)
    //    {
    //        if(number % 2 == 0)
    //        {
    //            Debug.Log("0���� ū ¦��.");
    //        }
    //        else
    //        {
    //            Debug.Log("0���� ū Ȧ��.");
    //        }
    //    }
    //    else
    //    {
    //        Debug.Log("0���� �۰ų� ���� ��.");
    //    }
    //}   �� : 0���� ū ¦��


    //private void Start()
    //{
    //    int number = 0;

    //    switch(number)
    //    {
    //        case 1:
    //            Debug.Log("�ϳ�");
    //            break;
    //        case 2:
    //            Debug.Log("��");
    //            break;
    //        case 3:
    //            Debug.Log("��");
    //            break;
    //        default:
    //            Debug.Log("1, 2, 3 �ۿ� �����");
    //            break;
    //    }
    //}   �� : 1, 2, 3 �ۿ� �����


    //private void Start()
    //{
    //    string day = "��";

    //    switch(day)
    //    {
    //        case "��":
    //            Debug.Log("Sunday");
    //            break;
    //        case "��":
    //            Debug.Log("Monday");
    //            break;
    //        case "ȭ":
    //            Debug.Log("Tuesday");
    //            break;
    //        case "��":
    //            Debug.Log("Wednesday");
    //            break;
    //        case "��":
    //            Debug.Log("Thursday");
    //            break;
    //        case "��":
    //            Debug.Log("Friday");
    //            break;
    //        case "��":
    //            Debug.Log("Saturday");
    //            break;
    //        default:
    //            Debug.Log($"{day}��(��) ������ �ƴմϴ�.");
    //            break;
    //    }
    //}   �� : Wednesday


    //enum CharacterState { IDLE, WALK, ATTACK, JUMP, DIE }

    //private void Start()
    //{
    //    CharacterState player = CharacterState.WALK;

    //    switch(player)
    //    {
    //        case CharacterState.IDLE:
    //            Debug.Log("�÷��̾�� �������Դϴ�.");
    //            break;
    //        case CharacterState.WALK:
    //            Debug.Log("�÷��̾�� �ȴ� ���Դϴ�.");
    //            break;
    //        case CharacterState.ATTACK:
    //            Debug.Log("�÷��̾�� ���� ���Դϴ�.");
    //            break;
    //        case CharacterState.JUMP:
    //            Debug.Log("�÷��̾ ���� ���Դϴ�.");
    //            break;
    //        case CharacterState.DIE:
    //            Debug.Log("�÷��̾ �׾����ϴ�.");
    //            break;
    //    }
    //}   �� : �÷��̾�� �ȴ� ���Դϴ�.


    //private void Start()
    //{
    //    int userInput = 82;
    //    int score = (userInput / 10) * 10;

    //    string grade = "";

    //    switch(score)
    //    {
    //        case 90:
    //            grade = "A";
    //            break;
    //        case 80:
    //            grade = "B";
    //            break;
    //        case 70:
    //            grade = "C";
    //            break;
    //        case 60:
    //            grade = "F";
    //            break;
    //    }
    //}   �� : B


    //private void Start()
    //{
    //    int a = 10;

    //    while (a > 0)
    //        Debug.Log(a--);   10  9  8  7  6  5  4  3  2  1

    //    a = 10;

    //    while(a > 0)
    //    {
    //        Debug.Log(a);     10  8  6  4  2
    //        a -= 2;
    //    }
    //}


    //private void Start()
    //{
    //    int i = 10;

    //    while(i > 0)
    //    {
    //        Debug.Log($"i : {i--}");  10  9  8  7  6  5  4  3  2  1
    //    }
    //}


    //private void Start()
    //{
    //    int a = 10;

    //    do
    //    {
    //        Debug.Log(a);     10  8  6  4  2
    //        a -= 2;
    //    }
    //    while (a > 0);
    //}


    //private void Start()
    //{
    //    int i = 10;

    //    do
    //    {
    //        Debug.Log($"a) i : {i--}"); 10  9  8  7  6  5  4  3  2  1
    //    }
    //    while (i > 0);

    //    do
    //    {
    //        Debug.Log($"b) i : {i--}"); 0
    //    }
    //    while (i > 0);
    //}


    //private void Start()
    //{
    //    for(int i = 0; i < 5; i++)
    //    {
    //        Debug.Log(i);     0  1  2  3  4
    //    }
    //}


    //private void Start()
    //{
    //    for (int i = 0; i < 5; i++)
    //    {
    //        for (int j = 0; j <= i; j++)
    //        {
    //            Debug.Log("*");   *  **  ***  ****  *****
    //        }
    //    }
    //}


    //private void Start()
    //{
    //    int[] arr = new int[] { 0, 1, 2, 3, 4 };

    //    foreach(int a in arr)
    //    {
    //        Debug.Log(a);     0  1  2  3  4
    //    }
    //}


    //private void Start()
    //{
    //    int i = 0;

    //    while(i >= 0)
    //    {
    //        if(i == 10)
    //        {
    //            break;
    //        }
    //        Debug.Log(i++);   0  1  2  3  4  5  6  7  8  9
    //    }
    //    Debug.Log("Prison Break");    Prison Break
    //}


    //private void Start()
    //{
    //    for (int i = 0; i < 10; i++)
    //    {
    //        if (i % 2 == 0)
    //        {
    //            continue;
    //        }
    //        Debug.Log($"{i} : Ȧ��");   1  3  5  7  9
    //    }
    //}


    //private void Start()
    //{
    //    Debug.Log("1");

    //    goto JUMP;

    //    Debug.Log("2");
    //    Debug.Log("3");

    //JUMP:
    //    Debug.Log("4");   1  4
    //}


    //private void Start()
    //{
        
    //    for (int i = 0; i < 100; i++)
    //    {
    //        for (int j = 0; j < 200; j++)
    //        {
    //            for (int k = 0; k < 50; k++)
    //            {
    //                if(i == 0 && j == 1)
    //                    goto EXIT_FOR;
    //            }
    //        }
    //    }

    //EXIT_FOR:
    //    Debug.Log("Exit");
    //}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B6 : MonoBehaviour
{
    private void Update()
    {
        // Input ���� �� �Է��� �����ϴ� Ŭ����
        if (Input.anyKeyDown)   // anyKeyDown �ƹ� �Է��� ���ʷ� ���� �� true
        {
            Debug.Log("�÷��̾ �ƹ� Ű�� �Է��ߴ�");
        }

        if (Input.anyKey)   // anyKey �ƹ� �Է��� ������ true
        {
            Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ִ�");
        }

        // GetKey Ű���� ��ư �Է��� ������ true
        if (Input.GetKeyDown(KeyCode.Return))   // return == enter
        {
            Debug.Log("�������� �����Ͽ���");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("�������� �̵���");
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("������ �̵��� ���߾���");
        }

    }
}

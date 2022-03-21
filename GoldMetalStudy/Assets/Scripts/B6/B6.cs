using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B6 : MonoBehaviour
{
    private void Update()
    {
        // Input 게임 내 입력을 관리하는 클래스
        if (Input.anyKeyDown)   // anyKeyDown 아무 입력을 최초로 받을 때 true
        {
            Debug.Log("플레이어가 아무 키를 입력했다");
        }

        if (Input.anyKey)   // anyKey 아무 입력을 받으면 true
        {
            Debug.Log("플레이어가 아무 키를 누르고 있다");
        }

        // GetKey 키보드 버튼 입력을 받으면 true
        if (Input.GetKeyDown(KeyCode.Return))   // return == enter
        {
            Debug.Log("아이템을 구입하였다");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽으로 이동중");
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽 이동을 멈추었다");
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B5_1 : MonoBehaviour
{
    // 초기화 영역 
    private void Awake()    // 게임 오브젝트 생성할 때, 최초 실행
    {
        Debug.Log("플레이어 데이터가 준비되었다");        
    }

    // 활성화 영역
    private void OnEnable() // 게임 오브젝트가 활성화 되었을 때
    {
        Debug.Log("플레이어가 로그인했다");
    }

    private void Start()    // 업데이트 시작 직전, 최초 실행
    {
        Debug.Log("사냥 장비를 챙겼다");
    }
    
    // 물리 영역
    private void FixedUpdate()  // 물리 연산 업데이트
    {
        Debug.Log("이동중");
    }

    // 게임로직 영역
    private void Update()   // 게임 로직 업데이트
    {
        Debug.Log("몬스터 사냥중");
    }

    private void LateUpdate()   // 모든 업데이트 끝난 후
    {
        Debug.Log("경험치 휙득");
    }

    // 비활성화 영역
    private void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃했다");
    }

    // 해체 영역
    private void OnDestroy()    // 게임 오브젝트가 삭제될 때
    {
        Debug.Log("플레이어 데이터를 해체하였다");
    }
}

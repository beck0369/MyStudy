using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B5_1 : MonoBehaviour
{
    // �ʱ�ȭ ���� 
    private void Awake()    // ���� ������Ʈ ������ ��, ���� ����
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ���");        
    }

    // Ȱ��ȭ ����
    private void OnEnable() // ���� ������Ʈ�� Ȱ��ȭ �Ǿ��� ��
    {
        Debug.Log("�÷��̾ �α����ߴ�");
    }

    private void Start()    // ������Ʈ ���� ����, ���� ����
    {
        Debug.Log("��� ��� ì���");
    }
    
    // ���� ����
    private void FixedUpdate()  // ���� ���� ������Ʈ
    {
        Debug.Log("�̵���");
    }

    // ���ӷ��� ����
    private void Update()   // ���� ���� ������Ʈ
    {
        Debug.Log("���� �����");
    }

    private void LateUpdate()   // ��� ������Ʈ ���� ��
    {
        Debug.Log("����ġ �׵�");
    }

    // ��Ȱ��ȭ ����
    private void OnDisable()
    {
        Debug.Log("�÷��̾ �α׾ƿ��ߴ�");
    }

    // ��ü ����
    private void OnDestroy()    // ���� ������Ʈ�� ������ ��
    {
        Debug.Log("�÷��̾� �����͸� ��ü�Ͽ���");
    }
}

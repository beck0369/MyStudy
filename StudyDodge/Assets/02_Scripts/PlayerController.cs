using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;  // �̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f;            // �̵��ӷ�

    private void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� playerRigidbody�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow) == true)
        //{
        //    // ���� ����Ű �Է��� ������ ��� z ���� �� �ֱ�
        //    playerRigidbody.AddForce(0f, 0f, speed);
        //}

        //if (Input.GetKey(KeyCode.DownArrow) == true)
        //{
        //    // �Ʒ��� ����Ű �Է��� ������ ��� -z ���� �� �ֱ�
        //    playerRigidbody.AddForce(0f, 0f, -speed);
        //}

        //if (Input.GetKey(KeyCode.RightArrow) == true)
        //{
        //    // ������ ����Ű �Է��� ������ ��� x ���� �� �ֱ�
        //    playerRigidbody.AddForce(speed, 0f, 0f);
        //}

        //if (Input.GetKey(KeyCode.LeftArrow) == true)
        //{
        //    // ���� ����Ű �Է��� ������ ��� -x ���� �� �ֱ�
        //    playerRigidbody.AddForce(-speed, 0f, 0f);
        //}

        // ������� �������� �Է°��� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // ���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 �ӵ��� (xSpeed, 0, zSpeed)�� ����
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        // ������ٵ��� �ӵ��� newVelocity �Ҵ�
        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        // �ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);

        GameManager gameManager = FindObjectOfType<GameManager>();  // ���� �����ϴ� GameManager Ÿ���� ������Ʈ�� ã�Ƽ� ��������
        gameManager.EndGame();  // ������ GameManager ������Ʈ�� EndGame() �޼��� ����
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;            // ź�� �̵� �ӷ�
    private Rigidbody bulletRigidbody;  // �̵��� ����� ������ٵ� ������Ʈ

    private void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();

        // ������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�
        bulletRigidbody.velocity = transform.forward * speed;

        // 3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other) // Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼ҵ�
    {
        if (other.tag == "Player")  // �浹�� ���� ���� ������Ʈ�� Player �±׸� ���� ���
        {
            PlayerController playerController = other.GetComponent<PlayerController>(); // ���� ���� ������Ʈ���� PlayerController ������Ʈ ��������

            if (playerController != null)   // �������κ��� PlayerController ������Ʈ�� �������� �� �����ߴٸ�
            {
                playerController.Die(); // ���� PlayerController ������Ʈ�� Die() �޼ҵ� ����
            }
        }
    }
}

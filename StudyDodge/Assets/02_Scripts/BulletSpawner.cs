using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; // ������ ź���� ���� ������
    public float spawnRateMin = 0.5f;   // �ּ� ���� �ֱ�
    public float spawnRateMax = 3f;     // �ִ� ���� �ֱ�

    private Transform target;   // �߻��� ���
    private float spawnRate;    // ���� �ֱ�
    private float timeAfterSpawn;   // �ֱ� ���� �������� ���� �ð�

    private void Start()
    {
        timeAfterSpawn = 0f;    // �ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);   // ź�� ���� ������ spawnRateMin�� spawnRateMax ���̿��� ���� ����
        target = FindObjectOfType<PlayerController>().transform;    // PlayerController ������Ʈ�� ���� ���� ������Ʈ�� ã�� ���� ������� ����
    }

    private void Update()
    {
        timeAfterSpawn += Time.deltaTime;   // timeAfterSpawn ����

        if (timeAfterSpawn >= spawnRate)    // �ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ�
        {
            timeAfterSpawn = 0f;    // ������ �ð��� ����

            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);  // bulletPrefab�� �������� transform.position ��ġ�� transform.rotation ȸ������ ����

            bullet.transform.LookAt(target);    // ������ bullet ���� ������Ʈ�� ���� ������ target�� ���ϵ��� ȸ��

            spawnRate = Random.Range(spawnRateMin, spawnRateMin);
        }
    }
}

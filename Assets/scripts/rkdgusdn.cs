using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class rkdgusdn : MonoBehaviour
{
    public int gold = 0;                    //������
    public float Hp = 100.0f;               //�Ǽ��� (�Ҽ����� �ִ� ����, ���� 'f' �ʼ�)
    public string playerName = "ȫ�浿";    //���ڿ� (������ ����)
    private bool isAlive = true;            //���� (��/������ ��Ÿ��) frue/false


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("���� ����");            //����Ƽ ����׿� �޼����� ���
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("���� ������"); 
    }
}

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
        //Debug.Log("���� ����");            //����Ƽ ����׿� �޼����� ���

        if (gold > 50)
        {
            Debug.Log("�������� ������ �� �ֽ��ϴ�. ");
        }
        else if (gold > 25)                     //glod�� 50���� ������ 25���� Ŭ��
        { 
            Debug.Log("�Ϻ� �������� ������ �� �ֽ��ϴ�. ");
        }
        else
        { 
            Debug.Log("���� �����մϴ�.");    
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("���� ������"); 

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gold = gold + 10;
            Debug.Log("���� ��� : " + gold);
        }
    }
}

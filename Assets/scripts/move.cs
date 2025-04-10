using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 20f;           //�̵��ӵ�
    public float jumpForce = 5f;             //���� ��

    public Rigidbody rb;                    //Rigidbody ������Ʈ�� �޾ƿ� ����

    private bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float moveX = Input.GetAxis("Horizontal");              //�¿� �̵�
        float moveZ = Input.GetAxis("Vertical");                //�յ� �̵�

        Vector3 Direction = new Vector3(moveX, 0, moveZ).normalized;        //�̵� ���� ����

        rb.MovePosition(transform.position + Direction * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded ==true)       //&& �׸���(and)������, \\ �Ǵ�(or)������
        { 
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;         //�ٴڿ��� �������
    }
    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;          //�ٴڿ��� ����������
    }
}

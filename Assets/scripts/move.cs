using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 20f;           //이동속도
    public float jumpForce = 5f;             //점프 힘

    public Rigidbody rb;                    //Rigidbody 컴포넌트를 받아올 변수

    private bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float moveX = Input.GetAxis("Horizontal");              //좌우 이동
        float moveZ = Input.GetAxis("Vertical");                //앞뒤 이동

        Vector3 Direction = new Vector3(moveX, 0, moveZ).normalized;        //이동 방향 벡터

        rb.MovePosition(transform.position + Direction * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded ==true)       //&& 그리고(and)연산자, \\ 또는(or)연산자
        { 
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;         //바닥에서 닿았을때
    }
    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;          //바닥에서 떨여졌을때
    }
}

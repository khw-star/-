using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class rkdgusdn : MonoBehaviour
{
    public int gold = 0;                    //정수형
    public float Hp = 100.0f;               //실수형 (소수점이 있는 숫자, 끝에 'f' 필수)
    public string playerName = "홍길동";    //문자열 (문자의 집합)
    private bool isAlive = true;            //논리형 (참/거짓을 나타냄) frue/false


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("게임 시작");            //유니티 디버그에 메세지를 출력
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("게임 진행중"); 
    }
}

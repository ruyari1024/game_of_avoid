using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurdle : MonoBehaviour
{

    // 여기에 이것 추가
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("Player"); //이것도 추가추가
    }

    void Update()
    {
        //프레임마다 등속으로 낙하
        transform.Translate(0, -0.03f, 0);

        //화면 밖으로 나오면 오브젝트 소멸시킴
        if (transform.position.y < -15.0f)
        {
            Destroy(gameObject);
        }

        // **** 충돌판정이다앗! ****
        Vector2 p1 = transform.position; //화살 중심좌표
        Vector2 p2 = this.player.transform.position; //플레이어 중심좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.1f; //화살반경
        float r2 = 0.8f; //플레이어 중심좌표

        if (d < r1 + r2)
        {
            //충돌하면 화살소멸시킴
            Destroy(gameObject);
        }

    }
}
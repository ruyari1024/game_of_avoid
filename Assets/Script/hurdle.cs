using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurdle : MonoBehaviour
{

    // ���⿡ �̰� �߰�
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("Player"); //�̰͵� �߰��߰�
    }

    void Update()
    {
        //�����Ӹ��� ������� ����
        transform.Translate(0, -0.03f, 0);

        //ȭ�� ������ ������ ������Ʈ �Ҹ��Ŵ
        if (transform.position.y < -15.0f)
        {
            Destroy(gameObject);
        }

        // **** �浹�����̴پ�! ****
        Vector2 p1 = transform.position; //ȭ�� �߽���ǥ
        Vector2 p2 = this.player.transform.position; //�÷��̾� �߽���ǥ
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.1f; //ȭ��ݰ�
        float r2 = 0.8f; //�÷��̾� �߽���ǥ

        if (d < r1 + r2)
        {
            //�浹�ϸ� ȭ��Ҹ��Ŵ
            Destroy(gameObject);
        }

    }
}
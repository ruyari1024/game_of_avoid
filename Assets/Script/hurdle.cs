using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurdle : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float destoryTime = 5f;

    void Start()
    {
        Destroy(gameObject, destoryTime);
    }

    void Update()
    {
        //�����Ӹ��� ������� ����
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
    }
}
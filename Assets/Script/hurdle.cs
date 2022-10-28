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
        //프레임마다 등속으로 낙하
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
    }
}
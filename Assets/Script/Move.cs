using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float moveX, moveY;

    [Header("�̵��ӵ� ����")]
    [SerializeField][Range(1f, 30f)] float moveSpeed = 20f;
    void Update()
    {
        //�̵� (�����¿�Ű : WSADŰ Ȥ�� �����¿��̵�Ű)
        moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        /*moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;*/

        transform.position = new Vector2(transform.position.x + moveX);

    }
}
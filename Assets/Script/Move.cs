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
        /*moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
*/
        transform.position = new Vector2(transform.position.x + moveX,-2.7f);
        Vector3 position = Camera.main.WorldToViewportPoint(transform.position);
        if (position.x < 0f) position.x = 0f;
        if (position.y < 0f) position.y = 0f;
        if (position.x > 1f) position.x = 1f;
        if (position.y > 1f) position.y = 1f;
        transform.position = Camera.main.ViewportToWorldPoint(position);
    }
}
using System.Collections;
using System.Collections.Generic;
using Unity.Networking.Transport.Relay;
using UnityEditor;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [Header ("�÷��̾� ������Ʈ �Է�")]
    [SerializeField] Transform target;

    [Space (10f)]
    [Header("ī�޶� ������ �ӵ� / ī�޶� ������ ����")]
    [Range (0.5f, 10f)]
    [SerializeField] float speed;

    [SerializeField] Vector2 center;
    [SerializeField] Vector2 size;

    float height;
    float width;
    private void Start()
    {
        height = Camera.main.orthographicSize;
        width = height * Screen.width / Screen.height;
    }

    //ī�޶� ������ ������ �ð������� ���� ���� ����� ����

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(center, size);
    }
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * speed);
        
        float lx = size.x * 0.5f - width;
        float clampX = Mathf.Clamp(transform.position.x, -lx + center.x, lx+center.x);
        
        float ly = size.y * 0.5f - height;
        float clampY = Mathf.Clamp(transform.position.y, -ly + center.y, ly + center.y);

        transform.position = new Vector3(clampX, clampY, -10f);
    }
}

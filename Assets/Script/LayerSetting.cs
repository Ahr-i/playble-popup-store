using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LayerSetting : MonoBehaviour
{
    private TilemapRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<TilemapRenderer>();
        spriteRenderer.sortingOrder = Mathf.RoundToInt(transform.position.y)*-1;
        //������y�� ���� �ݺ���ϰ� ����
    }
}

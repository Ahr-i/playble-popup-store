using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class FrameImage : MonoBehaviour
{
    [SerializeField] Tilemap tilemap; //������ ����

    public void SetFrame()
    {
        Instantiate(tilemap);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLobbyUI : MonoBehaviour
{
    [SerializeField] GameObject ui;

    private void Awake()
    {
        ui.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            //�÷��̾���
            ui.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            //�÷��̾���
            ui.SetActive(false);
        }
    }
}

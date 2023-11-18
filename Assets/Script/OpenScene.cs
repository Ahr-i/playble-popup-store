using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour
{
    [SerializeField] string SceneName;

    private bool isOpenServer = false;

    private void Awake()
    {
        //������ �����ִ��� ǥ���ϴ� UI
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            //�÷��̾��϶� ����

            if (isOpenServer)
            {
                //���������ȴٸ� 
                //�ش� ������ ���� => ���� ���� �����ϴ� ��ũ��Ʈ �߰�
            }
            else
            {
                // ���� ���� ���� ��ũ��Ʈ �߰�
                OpenServer();


            }
        }
        //���� ���� or ���� ����
    }

    private  void OpenServer()
    {
        if(SceneName != null)
        {
            isOpenServer = true;
            SceneManager.LoadScene(SceneName);
        }

    }
}

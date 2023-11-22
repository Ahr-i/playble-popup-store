using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenScene : MonoBehaviour
{
    [SerializeField] string SceneName;

    private bool isOpenServer = false;
    private Button hostButton;
    private Button clientButton;


    private void Awake()
    {
        //������ �����ִ��� ǥ���ϴ� UI
        hostButton = transform.GetChild(0).GetComponent<Button>();
        hostButton.onClick.AddListener(HostButtonClick);
        clientButton = transform.GetChild(1).GetComponent<Button>();
        clientButton.onClick.AddListener(ClientServer);
    }

    //���� �Ŵ������� �� �޾ƿ;��ϳ�

    private void HostButtonClick()
    {
        if (!isOpenServer)
        {
            isOpenServer=true;
            // ���� ���� ���� ��ũ��Ʈ �߰� 
            //�ش� ������ ���� => ���� ���� �����ϴ� ��ũ��Ʈ �߰�
            ClientServer();
        }
        else
        {
            Debug.Log("������ �̹� ���� ����");
        }
    }


    private  void ClientServer()
    {
        if(SceneName != null && isOpenServer)
        {
            isOpenServer = true;
            SceneManager.LoadScene(SceneName);
        }

    }
}

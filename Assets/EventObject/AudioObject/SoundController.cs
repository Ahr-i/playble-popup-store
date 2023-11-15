using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    [SerializeField] SoundData bgList;
    AudioSource bgSound;
    private int index = 0;

    [SerializeField] GameObject soundListUI;
    [SerializeField] GameObject soundPlayUI;
    Button leftButton, rightButton, playButton, pauseButton;
    Text title;

    private void Awake()
    {
        bgSound = GetComponent<AudioSource>();

        //UI
        title = soundListUI.transform.GetChild(1).GetComponent<Text>();
        rightButton = soundListUI.transform.GetChild(2).GetComponent<Button>();
        rightButton.onClick.AddListener(RightButton);

        leftButton = soundListUI.transform.GetChild(3).GetComponent<Button>();
        leftButton.onClick.AddListener(LeftButton);



        playButton = soundPlayUI.transform.GetChild(0).GetComponent<Button>();
        playButton.onClick.AddListener(OnPlayBGSound);

        pauseButton = soundPlayUI.transform.GetChild(1).GetComponent<Button>();
        pauseButton.onClick.AddListener(StopPlaySound);

        SetUI();
    }
    //���� ��������� ���� �� ������ ���� �����ϰ� �� ���� �ϴ� ��ũ��Ʈ ���(���߿� �����ִٸ�)

    //����� ���� �Լ�
    private void LeftButton()
    {
        if(index > 0)
        {
            index--;
            SetUI();
        }
    }

    private void RightButton()
    {
        if(index < bgList.sound.Length-1)
        {
            index++;
            SetUI();
        }
    }

    //UI���� 
    private void SetUI()
    {
        title.text = bgList.sound[index].soundName;

    }

    //����� �÷��� �Լ�
    public void OnPlayBGSound()
    {
        SetUI();
        bgSound.clip = bgList.sound[index].soundClip;
        bgSound.loop = true;
        bgSound.volume = 0.1f;
        bgSound.Play();
    }
    //����� ���� �Լ�
    public void StopPlaySound()
    {
        bgSound.Stop();
    }
    

}

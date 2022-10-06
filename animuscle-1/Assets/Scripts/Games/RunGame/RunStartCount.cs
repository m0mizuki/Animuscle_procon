using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//�X�^�[�g�O�̃J�E���g�_�E�����Ǘ�
public class RunStartCount : MonoBehaviour
{
    public  static bool RunStarted; //�X�^�[�g�ς݃t���O
    public TextMeshProUGUI CountDownText;
    public float totalTime; //�҂�����
    private int seconds;    //TMP�ŏo�͂���҂�����
    
    void Start()
    {
        RunStarted = false;
    }
    // Update is called once per frame
    void Update()
    {
        //�҂����Ԃ�0�ɂȂ�܂ŃJ�E���g�_�E�����A�����^�ɒ�����TMP�ŏo��
        totalTime -= Time.unscaledDeltaTime;
        seconds = (int)totalTime;
        CountDownText.text = seconds.ToString();

        /*�҂����Ԃ�0�ɂȂ�����X�^�[�g�ς݃t���O��true�ɂ��A
         *�Q�[�������Ԃ𓮂����ăJ�E���g�_�E������������
        */
        if (seconds <= 0)
        {
            RunStarted = true;
            Time.timeScale = 1;
            this.gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//�Q�[���̃N���A�^�C�����Ǘ�
public class RunTimeDisp : MonoBehaviour
{
    public TextMeshProUGUI TimerText;
    public  static float RunClearTime;
    // Start is called before the first frame update
    void Start()
    {
        RunClearTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //�X�^�[�g�ς݂̂Ƃ��J�E���g�ATMP�ŏo��
        if (RunStartCount.RunStarted)
        {
            RunClearTime += Time.deltaTime;
            TimerText.text = RunClearTime.ToString("f2");
        }
        //�X�^�[�g�ς݂łȂ��Ƃ��������i�����\�͂ɂ��X�^�[�g�O�ɋ͂��ɃJ�E���g�����ꍇ�����邽�߁j
        else
        {
            RunClearTime = 0f;
        }
    }
}

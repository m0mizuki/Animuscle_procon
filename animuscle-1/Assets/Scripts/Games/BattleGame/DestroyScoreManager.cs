using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class DestroyScoreManager : MonoBehaviour
{

    private Text destroyText;

    public static int destroyScore = 0;


    // Start is called before the first frame update
    void Start()
    {
        // ���̃X�N���v�g�����Ă���I�u�W�F�N�g�̒���Text�Ƃ���
        // �R���|�[�l���g���擾
        destroyText = GetComponentInChildren<Text>();
        destroyText.text = "0";

        destroyScore = 0;
    }

    // Update is called once per frame
    void Update()
    {

        // ������ŏ�������
        destroyText.text = destroyScore.ToString();


    }
}

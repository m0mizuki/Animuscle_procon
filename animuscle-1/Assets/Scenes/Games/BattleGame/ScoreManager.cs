using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;

    public int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        // ���̃X�N���v�g�����Ă���I�u�W�F�N�g�̒���Text�Ƃ���
        // �R���|�[�l���g���擾
        //scoreText = GetComponentInChildren<Text>();
        scoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        // score��int�^�Ȃ̂ŕ�����\�����邽�߂�ToStiring������
        scoreText.text = score.ToString()+"P";
    }
}

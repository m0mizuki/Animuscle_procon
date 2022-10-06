using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealBtnManager : MonoBehaviour
{

    private GameObject scoreText;

    public Button healSkill;  // �X�L���̃{�^���̖��O��錾���Ă���


    bool healSkillCT;


    // Start is called before the first frame update
    void Start()
    {
        // ScoreText �Ƃ����I�u�W�F�N�g��T���Ď擾
        scoreText = GameObject.Find("ScoreText");

        healSkill.interactable = false;  // �{�^���͉����Ȃ����Ă���

    }

    // Update is called once per frame
    void Update()
    {
        if (scoreText.GetComponent<ScoreManager>().score >= 5 && !healSkillCT)
        {
            healSkill.interactable = true;

        }
        else
        {
            healSkill.interactable = false;

        }
    }


    public void OnClick()
    {

        if (scoreText.GetComponent<ScoreManager>().score >= 5)
        {
            // �ĂԃX�N���v�g�ɂ�����������
            PlayerController playerController;
            // Enemy�Ƃ����I�u�W�F�N�g��T��
            GameObject obj = GameObject.Find("Player");

            if (obj)         // obj������Ȃ�
            {

                // ���Ă���X�N���v�g���擾
                playerController = obj.GetComponent<PlayerController>();


                // HealSkill �Ƃ������O�����Ă���v���O������
                // �擾�����X�N���v�g���Ŏ��s
                playerController.HealSkill();


                healSkillCT = true;
                StartCoroutine("HealSkillCT");// �R���[�`���Ăяo��

            }

            // �X�R�A�\�������Ă���Ƃ��납��g�����X�R�A���������炷
            scoreText.GetComponent<ScoreManager>().score = scoreText.GetComponent<ScoreManager>().score - 5;

        }

    }

    private IEnumerator HealSkillCT()// �X�L���̃N�[���^�C��
    {
        yield return new WaitForSeconds(7.0f);


        healSkillCT = false;

    }





}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AtkBtnManager : MonoBehaviour
{

    private GameObject scoreText;


    public Button attackSkill;






    bool atkSkillCT;




    // Start is called before the first frame update
    void Start()
    {
        // ScoreText �Ƃ����I�u�W�F�N�g��T���Ď擾
        scoreText = GameObject.Find("ScoreText");


        // ���̃{�^���������Ȃ�����
        attackSkill.interactable = false;


        atkSkillCT = false;

    }

    // Update is called once per frame
    void Update()
    {
        // attackSkil�̃{�^���̗L���E�����̐؂�ւ�
        if (scoreText.GetComponent<ScoreManager>().score >= 5 && !atkSkillCT)
        {

            // ������悤�ɂ���
            attackSkill.interactable = true;

        }
        else
        {
            attackSkill.interactable = false;

        }
    }


    public void OnClick()
    {

        if (scoreText.GetComponent<ScoreManager>().score >= 5)
        {
            // �ĂԃX�N���v�g�ɂ�����������
            EnemyController enemyController;

            // Enemy�Ƃ����I�u�W�F�N�g��T��
            GameObject obj = GameObject.Find("Enemy");

            if (obj)         // obj������Ȃ�
            {

                // ���Ă���X�N���v�g���擾
                enemyController = obj.GetComponent<EnemyController>();


                // AttackSkill �Ƃ������O�����Ă���v���O������
                // �擾�����X�N���v�g���Ŏ��s
                enemyController.AttackSkill();


                atkSkillCT = true;
                StartCoroutine("AtkSkillCT");// �R���[�`���Ăяo��

            }
            // �X�R�A�\�������Ă���Ƃ��납��g�����X�R�A���������炷
            scoreText.GetComponent<ScoreManager>().score = scoreText.GetComponent<ScoreManager>().score - 5;

        }




    }


    private IEnumerator AtkSkillCT()// �X�L���̃N�[���^�C��
    {
        // �N�[���^�C����5�b�ɐݒ�
        yield return new WaitForSeconds(5.0f);


        atkSkillCT = false;

    }



}

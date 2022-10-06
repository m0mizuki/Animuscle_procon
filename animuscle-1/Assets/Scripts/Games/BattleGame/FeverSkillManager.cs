using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FeverSkillManager : MonoBehaviour
{

    private GameObject scoreText;

    public Button feverSkill;



    public GameObject feverTimeText;
    public static int feverScore;


    bool feverSkillCT;


    // Start is called before the first frame update
    void Start()
    {
        // ScoreText�Ƃ����I�u�W�F�N�g��T���Ď擾
        scoreText = GameObject.Find("ScoreText");

        //���̃{�^���������Ȃ�����
        feverSkill.interactable = false;

        feverSkillCT = false;


        feverScore = 1;
        //���̃e�L�X�g�͔�\���ɂ��Ă���
        feverTimeText.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        //feverSkill�̃{�^���̗L���E�����̐؂�ւ�
        if (scoreText.GetComponent<ScoreManager>().score >= 4 && !feverSkillCT)
        {

            feverSkill.interactable = true;

        }
        else
        {
            feverSkill.interactable = false;

        }
    }

    public void OnClick()//�N���b�N�i�{�^���������ꂽ�j���Ɏ��s��������e
    {

         feverScore = 2;

        //�e�L�X�g��\������
        feverTimeText.SetActive(true);


        //feverSkill.interactable = false;
        feverSkillCT = true;
        StartCoroutine("FeverSkillCT");//�R���[�`���Ăяo��


        StartCoroutine("FinishFever");//�R���[�`���Ăяo��





        //�X�R�A�\�������Ă���Ƃ��납��g�����X�R�A���������炷
        scoreText.GetComponent<ScoreManager>().score = scoreText.GetComponent<ScoreManager>().score - 4;

        


    }

    private IEnumerator FeverSkillCT()//�X�L���̃N�[���^�C��
    {
        yield return new WaitForSeconds(7.0f);


        feverSkillCT = false;

    }




    private IEnumerator FinishFever()
    {
        //�����������t�B�[�o�[�^�C���̌p�����Ԃ��T�b�Ƃ���
        yield return new WaitForSeconds(5.0f);

        //���̃e�L�X�g�͔�\���ɂ���
        feverTimeText.SetActive(false);

        feverScore = 1;

    }



}

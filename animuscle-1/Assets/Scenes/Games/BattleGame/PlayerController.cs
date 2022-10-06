using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : PetStatusManager
{

    [SerializeField]
    private float attackDamage;  // player�̍U����

    [SerializeField]
    private Slider HPSlider;


    [SerializeField]
    private float attackSpeed;

    // player�̗̑�
    [System.NonSerialized]
    public float currentHealth;
    public float maxHealth;

    private Image petImage;
    public Sprite[] PetSprite;

    private GameObject scoreText;  // ���݂̃X�R�A���擾���邽�߂ɐ錾���Ă���



    public static int Score;  // FujiEnd�i�Q�[���I�[�o�[�̃V�[���j�Ŏg���X�R�A��錾
    //private GameObject destroyText;


    // �A�v���ɂ��X�e�[�^�X�A�b�v�𔽉f���A�Q�[�����̃X�e�[�^�X��ݒ�
    public void SetStatus(float arm, float abs, float leg)
    {

        attackSpeed = 2.0f - leg / 100;
        maxHealth = 100f + abs;
        attackDamage = 25f + arm / 1.25f;


        // �Q�[���J�n����HP���}�b�N�X�ɂ���
        currentHealth = maxHealth;


        // GameManager�X�N���v�g�� UpdateHealthUI �����s����
        GameManager.instance.UpdateHealthUI();



        // ���Ԋu�� DelayMwthod �Ƃ����v���O�����ɏ�����Ă��邱�Ƃ����s����
        InvokeRepeating(nameof(DelayMethod), attackSpeed, attackSpeed);  // player�̃N�[���^�C���I�Ȃ���

        scoreText = GameObject.Find("ScoreText");  // �X�R�A���擾
    }
    


    // Start is called before the first frame update
    void Start()
    {
        petImage = GetComponent<Image>();
        petImage.sprite = PetSprite[GameSerectManager.GamePetType];

    }

    void DelayMethod()
    {
        // �ĂԃX�N���v�g�ɂ�����������
        EnemyController enemyController;
        // Enemy�Ƃ����I�u�W�F�N�g��T��
        GameObject obj = GameObject.Find("Enemy");

        if (obj)         // obj������Ȃ�
        {

            // ���Ă���X�N���v�g���擾
            enemyController = obj.GetComponent<EnemyController>();


            // �_���[�W��^����
            enemyController.TakeDamage(attackDamage);
        }

    }


    private void OnDestroy()
    {


        CancelInvoke();

    }






    // Update is called once per frame
    void Update()
    {
        


    }


    public void TakeDamage(float damage)
    {
        // �_���[�W���󂯂�
        currentHealth -= damage;


        // HP���Ȃ��Ȃ����Ƃ��Ɏ��s�������
        if (currentHealth <= 0)
        {
            Destroy(gameObject);


            // BattleResult�Ƃ����V�[���Ɉڍs
            SceneManager.LoadScene("BattleResult");
        }
        GameManager.instance.UpdateHealthUI();
    }


    public static int GetScore()
    {

        return DestroyScoreManager.destroyScore;
    }

    public void HealSkill()
    {
        if(maxHealth - currentHealth <= maxHealth * 0.25f)
        {
            // ������HP��25%�ȉ��Ȃ�
            // HP���}�b�N�X�ɍ��킹��i����ȏ�ɂ����Ȃ��悤�ɂ���j
            currentHealth = maxHealth;
        }
        else
        {
            // HP�����25������
            currentHealth += maxHealth / 4;

        }



    }

    

}



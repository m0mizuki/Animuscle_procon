using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class EnemyController : MonoBehaviour
{


    [SerializeField]
    public float attackDamage;
    
    public float maxHealth;
    [System.NonSerialized]
    public float currentHealth;

    public int enemyScore;

    [SerializeField]
    private Slider EnemyHP;

    private  Image enemyImage;
    public Sprite[] enemySprite;


    GameObject audioManager;

    private GameObject scoreText;



    //DateTime dt;


    public FeverSkillManager feverSkillManager;

    



    // Start is called before the first frame update
    void Start()
    {

        // �Q�[���J�n����HP���}�b�N�X�ɂ���
        currentHealth = maxHealth;


        // GameManager�X�N���v�g�� UpdateEnemyHealthUI �����s����
        GameManager.instance.UpdateEnemyHealthUI();


        // ScoreText �Ƃ����I�u�W�F�N�g��T���Ď擾
        scoreText = GameObject.Find("ScoreText");



        // ���Ԋu�� DelayMwthod �Ƃ����v���O�����ɏ�����Ă��邱�Ƃ����s����
        InvokeRepeating(nameof(DelayMethod), 1.0f, 1.0f);

        //dt = DateTime.Now;

        audioManager = GameObject.FindWithTag("AudioManager"); //����AudioManager�擾


    }


    public void Create(int enemyType, int enemyPosition)
    {
        // Image�Ƃ����R���|�[�l���g���擾
        enemyImage = GetComponent<Image>();



        // �G�̃^�C�v1�̐ݒ�
        if (enemyType == 1)
        {
            attackDamage = 10f;
            maxHealth = 50f * (1.0f + DestroyScoreManager.destroyScore / 20);
            enemyImage.sprite = enemySprite[0];  // �����ł͌����ڂ�ݒ�
            enemyScore = 1;
        }

        // �G�̃^�C�v2�̐ݒ�
        if (enemyType == 2)
        {
            attackDamage = 10f;
            maxHealth = 100f * (1.0f + DestroyScoreManager.destroyScore / 20);
            enemyImage.sprite = enemySprite[1];
            enemyScore = 2;

        }

        // �G�̃^�C�v3�̐ݒ�
        if (enemyType == 3)
        {
            attackDamage = 15f;
            maxHealth = 75f * (1.0f + DestroyScoreManager.destroyScore / 20);
            enemyImage.sprite = enemySprite[2];
            enemyScore = 3;

        }

        // �G�̃^�C�v4�̐ݒ�
        if (enemyType == 4)
        {
            attackDamage = 20f;
            maxHealth = 200f * (1.0f + DestroyScoreManager.destroyScore / 20);
            enemyImage.sprite = enemySprite[3];
            enemyScore = 5;
        }



        // �o������ꏊ��^����
        if(enemyPosition == 0)
        {
            this.transform.position = new Vector3(150, 817, 0);
        }
        
        if(enemyPosition == 1)
        {
            this.transform.position = new Vector3(375, 817, 0);
        }
        
        if(enemyPosition == 2)
        {
            this.transform.position = new Vector3(600, 817, 0);
        }




    }





    void DelayMethod()
    {
        // �ĂԃX�N���v�g�ɂ�����������
        PlayerController playerController;
        // Player�Ƃ����I�u�W�F�N�g��T��
        GameObject obj = GameObject.Find("Player");

        if (obj)
        {
            // ���Ă���X�N���v�g���擾
            playerController = obj.GetComponent<PlayerController>();


            // �_���[�W��^����
            playerController.TakeDamage(attackDamage);
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



        if (currentHealth <= 0)
        {
            // PrefabScript���ł�enemyQuantity���P���炷
            PrefabScript.enemyQuantity--;

            // �I�u�W�F�N�g���폜
            Destroy(gameObject);

            audioManager.GetComponent<AudioManager>().AudioBuy();

            // �X�R�A�����Z�i�G�ɐݒ肵�Ă���X�R�A���j
            scoreText.GetComponent<ScoreManager>().score = scoreText.GetComponent<ScoreManager>().score + enemyScore * FeverSkillManager.feverScore;

            // �|�����������Z
            DestroyScoreManager.destroyScore = DestroyScoreManager.destroyScore + 1;
        }




        // GameManager.instance.UpdateEnemyHealthUI();
        EnemyHP.maxValue = maxHealth;
        EnemyHP.value = currentHealth;

    }



    public void AttackSkill()
    {

        PrefabScript.enemyQuantity--;


        Destroy(gameObject);

        DestroyScoreManager.destroyScore = DestroyScoreManager.destroyScore + 1;


    }

}

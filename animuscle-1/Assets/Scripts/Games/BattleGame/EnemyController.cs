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

        // ゲーム開始時にHPをマックスにする
        currentHealth = maxHealth;


        // GameManagerスクリプトの UpdateEnemyHealthUI を実行する
        GameManager.instance.UpdateEnemyHealthUI();


        // ScoreText というオブジェクトを探して取得
        scoreText = GameObject.Find("ScoreText");



        // 一定間隔で DelayMwthod というプログラムに書かれていることを実行する
        InvokeRepeating(nameof(DelayMethod), 1.0f, 1.0f);

        //dt = DateTime.Now;

        audioManager = GameObject.FindWithTag("AudioManager"); //直接AudioManager取得


    }


    public void Create(int enemyType, int enemyPosition)
    {
        // Imageというコンポーネントを取得
        enemyImage = GetComponent<Image>();



        // 敵のタイプ1の設定
        if (enemyType == 1)
        {
            attackDamage = 10f;
            maxHealth = 50f * (1.0f + DestroyScoreManager.destroyScore / 20);
            enemyImage.sprite = enemySprite[0];  // ここでは見た目を設定
            enemyScore = 1;
        }

        // 敵のタイプ2の設定
        if (enemyType == 2)
        {
            attackDamage = 10f;
            maxHealth = 100f * (1.0f + DestroyScoreManager.destroyScore / 20);
            enemyImage.sprite = enemySprite[1];
            enemyScore = 2;

        }

        // 敵のタイプ3の設定
        if (enemyType == 3)
        {
            attackDamage = 15f;
            maxHealth = 75f * (1.0f + DestroyScoreManager.destroyScore / 20);
            enemyImage.sprite = enemySprite[2];
            enemyScore = 3;

        }

        // 敵のタイプ4の設定
        if (enemyType == 4)
        {
            attackDamage = 20f;
            maxHealth = 200f * (1.0f + DestroyScoreManager.destroyScore / 20);
            enemyImage.sprite = enemySprite[3];
            enemyScore = 5;
        }



        // 出現する場所を与える
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
        // 呼ぶスクリプトにあだ名をつける
        PlayerController playerController;
        // Playerというオブジェクトを探す
        GameObject obj = GameObject.Find("Player");

        if (obj)
        {
            // ついているスクリプトを取得
            playerController = obj.GetComponent<PlayerController>();


            // ダメージを与える
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
        // ダメージを受ける
        currentHealth -= damage;



        if (currentHealth <= 0)
        {
            // PrefabScript内でのenemyQuantityを１減らす
            PrefabScript.enemyQuantity--;

            // オブジェクトを削除
            Destroy(gameObject);

            audioManager.GetComponent<AudioManager>().AudioBuy();

            // スコアを加算（敵に設定してあるスコア分）
            scoreText.GetComponent<ScoreManager>().score = scoreText.GetComponent<ScoreManager>().score + enemyScore * FeverSkillManager.feverScore;

            // 倒した数を加算
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

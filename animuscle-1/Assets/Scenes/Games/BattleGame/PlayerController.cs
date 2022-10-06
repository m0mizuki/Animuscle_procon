using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : PetStatusManager
{

    [SerializeField]
    private float attackDamage;  // playerの攻撃力

    [SerializeField]
    private Slider HPSlider;


    [SerializeField]
    private float attackSpeed;

    // playerの体力
    [System.NonSerialized]
    public float currentHealth;
    public float maxHealth;

    private Image petImage;
    public Sprite[] PetSprite;

    private GameObject scoreText;  // 現在のスコアを取得するために宣言しておく



    public static int Score;  // FujiEnd（ゲームオーバーのシーン）で使うスコアを宣言
    //private GameObject destroyText;


    // アプリによるステータスアップを反映し、ゲーム内のステータスを設定
    public void SetStatus(float arm, float abs, float leg)
    {

        attackSpeed = 2.0f - leg / 100;
        maxHealth = 100f + abs;
        attackDamage = 25f + arm / 1.25f;


        // ゲーム開始時にHPをマックスにする
        currentHealth = maxHealth;


        // GameManagerスクリプトの UpdateHealthUI を実行する
        GameManager.instance.UpdateHealthUI();



        // 一定間隔で DelayMwthod というプログラムに書かれていることを実行する
        InvokeRepeating(nameof(DelayMethod), attackSpeed, attackSpeed);  // playerのクールタイム的なもの

        scoreText = GameObject.Find("ScoreText");  // スコアを取得
    }
    


    // Start is called before the first frame update
    void Start()
    {
        petImage = GetComponent<Image>();
        petImage.sprite = PetSprite[GameSerectManager.GamePetType];

    }

    void DelayMethod()
    {
        // 呼ぶスクリプトにあだ名をつける
        EnemyController enemyController;
        // Enemyというオブジェクトを探す
        GameObject obj = GameObject.Find("Enemy");

        if (obj)         // objがあるなら
        {

            // ついているスクリプトを取得
            enemyController = obj.GetComponent<EnemyController>();


            // ダメージを与える
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
        // ダメージを受ける
        currentHealth -= damage;


        // HPがなくなったときに実行するもの
        if (currentHealth <= 0)
        {
            Destroy(gameObject);


            // BattleResultというシーンに移行
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
            // 減ったHPが25%以下なら
            // HPをマックスに合わせる（それ以上にさせないようにする）
            currentHealth = maxHealth;
        }
        else
        {
            // HP上限の25％分回復
            currentHealth += maxHealth / 4;

        }



    }

    

}



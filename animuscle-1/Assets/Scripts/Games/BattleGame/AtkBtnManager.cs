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
        // ScoreText というオブジェクトを探して取得
        scoreText = GameObject.Find("ScoreText");


        // このボタンを押せなくする
        attackSkill.interactable = false;


        atkSkillCT = false;

    }

    // Update is called once per frame
    void Update()
    {
        // attackSkilのボタンの有効・無効の切り替え
        if (scoreText.GetComponent<ScoreManager>().score >= 5 && !atkSkillCT)
        {

            // 押せるようにする
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
            // 呼ぶスクリプトにあだ名をつける
            EnemyController enemyController;

            // Enemyというオブジェクトを探す
            GameObject obj = GameObject.Find("Enemy");

            if (obj)         // objがあるなら
            {

                // ついているスクリプトを取得
                enemyController = obj.GetComponent<EnemyController>();


                // AttackSkill という名前がついているプログラムを
                // 取得したスクリプト内で実行
                enemyController.AttackSkill();


                atkSkillCT = true;
                StartCoroutine("AtkSkillCT");// コルーチン呼び出し

            }
            // スコア表示をしているところから使ったスコア分だけ減らす
            scoreText.GetComponent<ScoreManager>().score = scoreText.GetComponent<ScoreManager>().score - 5;

        }




    }


    private IEnumerator AtkSkillCT()// スキルのクールタイム
    {
        // クールタイムを5秒に設定
        yield return new WaitForSeconds(5.0f);


        atkSkillCT = false;

    }



}

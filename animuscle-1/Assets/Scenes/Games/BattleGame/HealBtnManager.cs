using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealBtnManager : MonoBehaviour
{

    private GameObject scoreText;

    public Button healSkill;  // スキルのボタンの名前を宣言しておく


    bool healSkillCT;


    // Start is called before the first frame update
    void Start()
    {
        // ScoreText というオブジェクトを探して取得
        scoreText = GameObject.Find("ScoreText");

        healSkill.interactable = false;  // ボタンは押せなくしておく

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
            // 呼ぶスクリプトにあだ名をつける
            PlayerController playerController;
            // Enemyというオブジェクトを探す
            GameObject obj = GameObject.Find("Player");

            if (obj)         // objがあるなら
            {

                // ついているスクリプトを取得
                playerController = obj.GetComponent<PlayerController>();


                // HealSkill という名前がついているプログラムを
                // 取得したスクリプト内で実行
                playerController.HealSkill();


                healSkillCT = true;
                StartCoroutine("HealSkillCT");// コルーチン呼び出し

            }

            // スコア表示をしているところから使ったスコア分だけ減らす
            scoreText.GetComponent<ScoreManager>().score = scoreText.GetComponent<ScoreManager>().score - 5;

        }

    }

    private IEnumerator HealSkillCT()// スキルのクールタイム
    {
        yield return new WaitForSeconds(7.0f);


        healSkillCT = false;

    }





}

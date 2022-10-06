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
        // ScoreTextというオブジェクトを探して取得
        scoreText = GameObject.Find("ScoreText");

        //このボタンを押せなくする
        feverSkill.interactable = false;

        feverSkillCT = false;


        feverScore = 1;
        //このテキストは非表示にしておく
        feverTimeText.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        //feverSkillのボタンの有効・無効の切り替え
        if (scoreText.GetComponent<ScoreManager>().score >= 4 && !feverSkillCT)
        {

            feverSkill.interactable = true;

        }
        else
        {
            feverSkill.interactable = false;

        }
    }

    public void OnClick()//クリック（ボタンが押された）時に実行させる内容
    {

         feverScore = 2;

        //テキストを表示する
        feverTimeText.SetActive(true);


        //feverSkill.interactable = false;
        feverSkillCT = true;
        StartCoroutine("FeverSkillCT");//コルーチン呼び出し


        StartCoroutine("FinishFever");//コルーチン呼び出し





        //スコア表示をしているところから使ったスコア分だけ減らす
        scoreText.GetComponent<ScoreManager>().score = scoreText.GetComponent<ScoreManager>().score - 4;

        


    }

    private IEnumerator FeverSkillCT()//スキルのクールタイム
    {
        yield return new WaitForSeconds(7.0f);


        feverSkillCT = false;

    }




    private IEnumerator FinishFever()
    {
        //発生させたフィーバータイムの継続時間を５秒とする
        yield return new WaitForSeconds(5.0f);

        //このテキストは非表示にする
        feverTimeText.SetActive(false);

        feverScore = 1;

    }



}

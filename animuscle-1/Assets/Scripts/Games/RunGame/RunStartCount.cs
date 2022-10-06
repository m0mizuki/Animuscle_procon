using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//スタート前のカウントダウンを管理
public class RunStartCount : MonoBehaviour
{
    public  static bool RunStarted; //スタート済みフラグ
    public TextMeshProUGUI CountDownText;
    public float totalTime; //待ち時間
    private int seconds;    //TMPで出力する待ち時間
    
    void Start()
    {
        RunStarted = false;
    }
    // Update is called once per frame
    void Update()
    {
        //待ち時間が0になるまでカウントダウンし、整数型に直してTMPで出力
        totalTime -= Time.unscaledDeltaTime;
        seconds = (int)totalTime;
        CountDownText.text = seconds.ToString();

        /*待ち時間が0になったらスタート済みフラグをtrueにし、
         *ゲーム内時間を動かしてカウントダウン文字を消す
        */
        if (seconds <= 0)
        {
            RunStarted = true;
            Time.timeScale = 1;
            this.gameObject.SetActive(false);
        }
    }
}

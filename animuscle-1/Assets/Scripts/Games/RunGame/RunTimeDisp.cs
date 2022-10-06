using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//ゲームのクリアタイムを管理
public class RunTimeDisp : MonoBehaviour
{
    public TextMeshProUGUI TimerText;
    public  static float RunClearTime;
    // Start is called before the first frame update
    void Start()
    {
        RunClearTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //スタート済みのときカウント、TMPで出力
        if (RunStartCount.RunStarted)
        {
            RunClearTime += Time.deltaTime;
            TimerText.text = RunClearTime.ToString("f2");
        }
        //スタート済みでないとき初期化（処理能力によりスタート前に僅かにカウントされる場合があるため）
        else
        {
            RunClearTime = 0f;
        }
    }
}

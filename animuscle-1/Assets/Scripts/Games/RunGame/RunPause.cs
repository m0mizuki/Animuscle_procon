using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ポーズボタンとポーズ中に表示するボタンを管理
public class RunPause : MonoBehaviour
{
    private bool Paused;
    // Start is called before the first frame update
    void Start()
    {
        Paused = false;
        //子オブジェクト（ポーズ中に表示するボタン）を初期状態で非表示に設定
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    public void Pushed()
    {
        //ポーズ中だった場合、ポーズを解除して子オブジェクト（ポーズ中に表示するボタン）を非表示
        if (Paused)
        {
            Paused = false;
            //ゲーム開始済みの場合、ゲーム内時間を動かす（ゲーム開始前に動いてしまうことを防ぐ）
            if (RunStartCount.RunStarted)
            {
                Time.timeScale = 1;
            }
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(false);
            }
        }
        //ポーズ中でなかった場合、ポーズを有効にしてゲーム内時間を停止し、子オブジェクト（ポーズ中に表示するボタン）を表示
        else if (!Paused)
        {
            Paused = true;
            Time.timeScale = 0;
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(true);
            }
        }
    }
}

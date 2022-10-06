using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class DestroyScoreManager : MonoBehaviour
{

    private Text destroyText;

    public static int destroyScore = 0;


    // Start is called before the first frame update
    void Start()
    {
        // このスクリプトがついているオブジェクトの中のTextという
        // コンポーネントを取得
        destroyText = GetComponentInChildren<Text>();
        destroyText.text = "0";

        destroyScore = 0;
    }

    // Update is called once per frame
    void Update()
    {

        // 文字列で書き込む
        destroyText.text = destroyScore.ToString();


    }
}

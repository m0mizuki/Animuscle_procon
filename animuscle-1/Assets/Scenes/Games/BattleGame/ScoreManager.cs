using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;

    public int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        // このスクリプトがついているオブジェクトの中のTextという
        // コンポーネントを取得
        //scoreText = GetComponentInChildren<Text>();
        scoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        // scoreはint型なので文字列表示するためにToStiringを書く
        scoreText.text = score.ToString()+"P";
    }
}

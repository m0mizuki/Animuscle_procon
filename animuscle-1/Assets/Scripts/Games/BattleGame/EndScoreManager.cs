using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class EndScoreManager : MonoBehaviour
{

    public TextMeshProUGUI endCount;

    //public int endScore;



    // Start is called before the first frame update
    void Start()
    {
        // このスクリプトがついているオブジェクトの中のTextという
        // コンポーネントを取得
        //endCount = GetComponentInChildren<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        endCount.text = DestroyScoreManager.destroyScore.ToString();

    }
}

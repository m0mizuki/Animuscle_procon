using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//拾ったコインの枚数をTMPで出力
public class RunCoinDisp : MonoBehaviour
{
    public TextMeshProUGUI CoinText;
    // Update is called once per frame
    void Update()
    {
        CoinText.text = RunPlayer.RunCoin.ToString();
    }
}

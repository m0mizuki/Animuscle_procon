using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//�E�����R�C���̖�����TMP�ŏo��
public class RunCoinDisp : MonoBehaviour
{
    public TextMeshProUGUI CoinText;
    // Update is called once per frame
    void Update()
    {
        CoinText.text = RunPlayer.RunCoin.ToString();
    }
}

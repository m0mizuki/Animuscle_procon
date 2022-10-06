using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//E‚Á‚½ƒRƒCƒ“‚Ì–‡”‚ğTMP‚Åo—Í
public class RunCoinDisp : MonoBehaviour
{
    public TextMeshProUGUI CoinText;
    // Update is called once per frame
    void Update()
    {
        CoinText.text = RunPlayer.RunCoin.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KintoreText : MonoBehaviour
{
    TextMeshProUGUI kintoreText;

    public static string kintoreKind;

    // Start is called before the first frame update
    void Start()
    {
        //筋トレ時の表示される文字を変更
        kintoreText = GetComponent<TextMeshProUGUI>();


        switch (KintoreChangeScene.Kintore)
        {
            case 0:
                kintoreKind = "腕立て伏せ";
                break;
            case 1:
                kintoreKind = "腹筋";
                break;
            case 2:
                kintoreKind = "スクワット";
                break;
            default :
                break;
        }
        kintoreText.text = kintoreKind;
    }
}

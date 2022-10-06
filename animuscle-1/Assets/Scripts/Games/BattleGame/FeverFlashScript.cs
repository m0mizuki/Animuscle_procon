using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeverFlashScript : MonoBehaviour
{

    private Text feverText;
    private float feverSpeed = 1.2f;
    private float feverTime;




    // Start is called before the first frame update
    void Start()
    {
        // このオブジェクトからTextというコンポーネントを取得
        feverText = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        feverText.color = GetAlphaColor(feverText.color);
    }

    // テキストを点滅表示させる
    Color GetAlphaColor(Color color)
    {
        feverTime += Time.deltaTime * 5.0f * feverSpeed;
        color.a = Mathf.Sin(feverTime);

        return color;
    }

}

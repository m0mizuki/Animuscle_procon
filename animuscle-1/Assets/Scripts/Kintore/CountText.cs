using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountText : MonoBehaviour
{
    //筋トレの回数をカウント
    TextMeshProUGUI ctext;

    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        ctext = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {

        count = KintoreManager.count;
        ctext.text = count.ToString();

    }
}

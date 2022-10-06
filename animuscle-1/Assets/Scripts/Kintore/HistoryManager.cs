using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System;
using System.Linq;

public class HistoryManager : MonoBehaviour
{
    public GameObject Parent;
    public GameObject prefab;

    TextMeshProUGUI historyText;

    public TextMeshProUGUI udetateTMP;
    public TextMeshProUGUI hukkinTMP;
    public TextMeshProUGUI sukuwattoTMP;

    // Start is called before the first frame update
    void Start()
    {
        //通算回数のパス
        string historyPath = Application.persistentDataPath + "/history.txt";

        //履歴保存ファイルのパス
        string[] totalPath = new string[]{
        Application.persistentDataPath + "/udetate_t.txt",
        Application.persistentDataPath + "/hukkin_t.txt",
        Application.persistentDataPath + "/sukuwatto_t.txt"
        };


        if (!File.Exists(totalPath[0]))
        {
            File.WriteAllText(totalPath[0], "0");
        }
        udetateTMP.text = "腕立て : " + File.ReadAllText(totalPath[0]) + "回";


        if (!File.Exists(totalPath[1]))
        {
            File.WriteAllText(totalPath[1], "0");
        }
        hukkinTMP.text = "腹筋 : " + File.ReadAllText(totalPath[1]) + "回";

        if (!File.Exists(totalPath[2]))
        {
            File.WriteAllText(totalPath[2], "0");
        }
        sukuwattoTMP.text = "スクワット : " + File.ReadAllText(totalPath[2]) + "回";

        if (File.Exists(historyPath))
        {
            string[] lines = File.ReadAllLines(historyPath);
            int maxSize = lines.Length - 1;

            for (int i = maxSize; i > 0; i -= 3)
            {
                int kaisuu = int.Parse(File.ReadLines(historyPath).Skip(i).First());
                int time = int.Parse(File.ReadLines(historyPath).Skip(i - 1).First());
                int status = int.Parse(File.ReadLines(historyPath).Skip(i - 2).First());
                UnityEngine.Debug.Log(time + " " + status);

                GameObject Children = Instantiate(prefab, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

                Children.transform.SetParent(Parent.transform);
                Children.transform.position = new Vector3(0.0f, 0.0f, 0.0f);

                Children.transform.localScale = new Vector3(1f, 1f, 1f);

                GameObject obj = Children.transform.GetChild(0).gameObject;
                historyText = obj.GetComponent<TextMeshProUGUI>();



                string kintoreKind = null;

                //筋トレの種類に応じて色を変更
                switch (status)
                {
                    case 0:
                        kintoreKind = "腕立て";// "腕立て";
                        Children.GetComponent<Image>().color = new Color(255f / 255f, 150f / 255f, 150f / 255f);
                        break;
                    case 1:
                        kintoreKind = "腹筋";//"腹筋";
                        Children.GetComponent<Image>().color = new Color(150f / 255f, 255f / 255f, 150f / 255f);
                        break;
                    case 2:
                        kintoreKind = "スクワット"; //"スクワット";
                        Children.GetComponent<Image>().color = new Color(150f / 255f, 150f / 255f, 255f / 255f);
                        break;
                    default:
                        break;
                }
                historyText.text = DateTimeOffset.FromUnixTimeSeconds(time).Year + "年 "
                    + DateTimeOffset.FromUnixTimeSeconds(time).Month + "月 "
                    + DateTimeOffset.FromUnixTimeSeconds(time).Day + "日 "
                    //+ DateTimeOffset.FromUnixTimeSeconds(time).Hour + ":"
                    //+ DateTimeOffset.FromUnixTimeSeconds(time).Minute
                    + " " + kintoreKind;// + " " + kaisuu + "回";
                //DateTimeOffset.FromUnixTimeSeconds(time).LocalDateTime 
            }
        }

    }
}

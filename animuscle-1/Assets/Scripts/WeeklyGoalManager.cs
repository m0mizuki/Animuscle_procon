using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using TMPro;

public class WeeklyGoalManager : MonoBehaviour
{

    string path = "WeeklyGoal.txt";

    int[][] WeeklyGoal =
        {
            new int[3], //目標,0~2:腕立て、腹筋、スクワットのセット数
            new int[3] //達成した数
        };

    int[] WeeklyGoalKari = new int[3];

    public GameObject WeeklyGoalWindow;

    public TextMeshProUGUI UdetateNumText;
    public TextMeshProUGUI HukkinNumText;
    public TextMeshProUGUI SquatNumText;

    public TextMeshProUGUI UdetateGoalText;
    public TextMeshProUGUI HukkinGoalText;
    public TextMeshProUGUI SquatGoalText;

    //ペットステータスのセーブデータを配列に変換
    void StrToIntArray(string strWeeklyGoal)
    {
        int j = 0;
        int k = 0;
        int kari = 0;
        for (int i = 0; i < strWeeklyGoal.Length; i++)
        {
            //ASCIIで\n->10,\r->13,改行はwindowsは\r\n,macは\n
            if (strWeeklyGoal[i] == '-')
            {
                WeeklyGoal[j][k] = kari;
                kari = 0;
                k++;
            }
            else if (strWeeklyGoal[i] == '\n')
            {
                j++;
                k = 0;

            }
            else if (strWeeklyGoal[i] != '\r') kari = kari * 10 + strWeeklyGoal[i] - '0';
        }
    }

    //配列のペットステータスをセーブデータに変換
    string IntArrayToStr(int row, int column)
    {
        string a = "";
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                a = a + WeeklyGoal[i][j].ToString() + '-';
                if (j == column - 1) a = a + '\n';
            }
        }
        return a;
    }

    // Start is called before the first frame update
    void Start()
    {
        path = Path.Combine(Application.persistentDataPath,path);

        //表示するテキストの設定
        WeeklyGoalWindow.SetActive(false);
        StrToIntArray(File.ReadAllText(path));
        UdetateGoalText.text = "目標数:" + WeeklyGoal[0][0].ToString() + "セット\n達成数:" + WeeklyGoal[1][0].ToString() + "セット";
        HukkinGoalText.text = "目標数:" + WeeklyGoal[0][1].ToString() + "セット\n達成数:" + WeeklyGoal[1][1].ToString() + "セット";
        SquatGoalText.text = "目標数:" + WeeklyGoal[0][2].ToString() + "セット\n達成数:" + WeeklyGoal[1][2].ToString() + "セット";
    }

    //表示するテキストをを反映
    void SetNumText()
    {
        UdetateNumText.text = WeeklyGoalKari[0].ToString();
        HukkinNumText.text = WeeklyGoalKari[1].ToString();
        SquatNumText.text = WeeklyGoalKari[2].ToString();
    }

    //WeeKGoalWindowを開ける
    public void WeeKGoalWindowOpen()
    {
        for (int i = 0; i < 3; i++) WeeklyGoalKari[i] = WeeklyGoal[0][i];

        WeeklyGoalWindow.SetActive(true);
        SetNumText();
    }

    //WeeKGoalWindowを閉じる
    public void WeekGoalWindowClose(bool save)
    {
        WeeklyGoalWindow.SetActive(false);
        //セーブ
        if (save)
        {
            for (int i = 0; i < 3; i++) WeeklyGoal[0][i] = WeeklyGoalKari[i];
            File.WriteAllText(path, IntArrayToStr(2, 3));
        }
        UdetateGoalText.text = "目標数:" + WeeklyGoal[0][0].ToString() + "セット\n達成数:" + WeeklyGoal[1][0].ToString() + "セット";
        HukkinGoalText.text = "目標数:" + WeeklyGoal[0][1].ToString() + "セット\n達成数:" + WeeklyGoal[1][1].ToString() + "セット";
        SquatGoalText.text = "目標数:" + WeeklyGoal[0][2].ToString() + "セット\n達成数:" + WeeklyGoal[1][2].ToString() + "セット";
    }

    //数字を増やす
    public void AddNum(int type) 
    {
        WeeklyGoalKari[type]++;
        if (WeeklyGoalKari[type] > 99) WeeklyGoalKari[type] = 99;
        SetNumText();
    }

    //数字を減らす
    public void SubNum(int type)
    {
        WeeklyGoalKari[type]--;
        if (WeeklyGoalKari[type] < 0) WeeklyGoalKari[type] = 0;
        SetNumText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

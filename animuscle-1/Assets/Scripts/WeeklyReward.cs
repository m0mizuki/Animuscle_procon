using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class WeeklyReward : MonoBehaviour
{
    string UseDatePath = "UseDate.txt";
    string WeeklyGoalPath = "WeeklyGoal.txt";
    string CoinPath = "coin.txt";
    string DailyGameCountPath = "DailyGameCount.txt";

    public GameObject WeeklyRewardWindow;
    public GameObject textA;
    public GameObject textB;

    GameObject[] Pets;

    int[][] WeeklyGoal =
        {
            new int[3], //目標,0~2:腕立て、腹筋、スクワットのセット数
            new int[3] //達成した数
        };

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
        UseDatePath = Path.Combine(Application.persistentDataPath,UseDatePath);
        WeeklyGoalPath = Path.Combine(Application.persistentDataPath, WeeklyGoalPath);
        CoinPath = Path.Combine(Application.persistentDataPath,CoinPath);
        DailyGameCountPath = Path.Combine(Application.persistentDataPath,DailyGameCountPath);

        //日にち等を取得
        DateTime dt = DateTime.Now;
        string strDateData = File.ReadAllText(UseDatePath);

        int PastDate = (strDateData[0] - '0') * 10 + strDateData[1] - '0';
        int PastWeek = strDateData[2] - '0';
        int PastMonth = (strDateData[3] - '0') * 10 + strDateData[4] - '0';

        int NowDate = dt.Day;
        int NowWeek = 0;
        switch (dt.DayOfWeek)
        {
            case DayOfWeek.Sunday:
                NowWeek = 0;
                break;
            case DayOfWeek.Monday:
                NowWeek = 1;
                break;
            case DayOfWeek.Tuesday:
                NowWeek = 2;
                break;
            case DayOfWeek.Wednesday:
                NowWeek = 3;
                break;
            case DayOfWeek.Thursday:
                NowWeek = 4;
                break;
            case DayOfWeek.Friday:
                NowWeek = 5;
                break;
            case DayOfWeek.Saturday:
                NowWeek = 6;
                break;
        }
        int NowMonth = dt.Month;

        //ログインが一週間のはじめかを判定
        bool FirstOfWeek = false;
        if (PastWeek > NowWeek) FirstOfWeek = true;
        if (NowDate - PastDate > 6) FirstOfWeek = true;
        //else if (DateTime.DaysInMonth(2022, PastMonth) + NowDate - PastDate > 6) FirstOfWeek = true;

        //セーブデータ作成
        if (NowDate < 10) strDateData = '0' + NowDate.ToString();
        else strDateData = NowDate.ToString();
        strDateData = strDateData + NowWeek.ToString();
        if (NowMonth < 10) strDateData = strDateData + '0' + NowMonth.ToString();
        else strDateData = strDateData + NowMonth.ToString();

        //ログインが1日のはじめかを判定
        if (File.ReadAllText(UseDatePath) != strDateData)
        {
            File.WriteAllText(DailyGameCountPath, "0-0-0-");
        }

        //セーブ
        File.WriteAllText(UseDatePath, strDateData);

        if (FirstOfWeek)
        {
            WeeklyRewardWindow.SetActive(true);

            Pets = GameObject.FindGameObjectsWithTag("pet"); //petタグのGameObjectをすべて取得
            foreach (GameObject pets in Pets)
            {
                pets.SetActive(false);
            }

            //目標チェック
            StrToIntArray(File.ReadAllText(WeeklyGoalPath));
            bool achieved = true;
            for(int i = 0; i < 3; i++)
            {
                if (WeeklyGoal[0][i] > WeeklyGoal[1][i]) achieved = false;
            }
            //目標が達成出来たら多く報酬を受け取る
            if (achieved)
            {
                textA.SetActive(true);
                textB.SetActive(false);
                NodeMaker.Coin += 30;
                File.WriteAllText(CoinPath, NodeMaker.Coin.ToString());
            }
            else
            {
                textA.SetActive(false);
                textB.SetActive(true);
                NodeMaker.Coin += 10;
                File.WriteAllText(CoinPath, NodeMaker.Coin.ToString());
            }

            for (int i = 0; i < 3; i++)
            {
                WeeklyGoal[0][i] = 0;
            }
            File.WriteAllText(CoinPath, IntArrayToStr(2, 3));
        }

    }

    //週の報酬画面を閉じる
    public void CloseWindow()
    {
        WeeklyRewardWindow.SetActive(false);
        foreach (GameObject pets in Pets)
        {
            pets.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

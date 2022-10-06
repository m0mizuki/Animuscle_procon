using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.IO;

//リザルト画面の文字表示を管理
public class RunResultDisp : MonoBehaviour
{
    public TextMeshProUGUI CoinText;
    public TextMeshProUGUI TimeText;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI GetCoinText;
    private float score;

    string path = "DailyGameCount.txt";
    string CoinPath = "coin.txt";
    string PetStatusPath = "PetStatus.txt";

    int[][] PetStatus =
        {
            new int[6], //ペット1,配列0~2:腕,腹,脚ステータス,3~5:ゲーム1~3の熟練度
            new int[6], //ペット2
            new int[6] //ペット3
        };

    void StrToIntArray(string strPetStatus)
    {
        int j = 0;
        int k = 0;
        int kari = 0;
        for (int i = 0; i < strPetStatus.Length; i++)
        {
            //ASCIIで\n->10,\r->13,改行はwindowsは\r\n,macは\n
            if (strPetStatus[i] == '-')
            {
                PetStatus[j][k] = kari;
                kari = 0;
                k++;
            }
            else if (strPetStatus[i] == '\n')
            {
                j++;
                k = 0;

            }
            else if (strPetStatus[i] != '\r') kari = kari * 10 + strPetStatus[i] - '0';
        }
        for (int a = 0; a < 3; a++)
        {
            for (int b = 0; b < 6; b++)
            {
                Debug.Log(PetStatus[a][b]);
            }
        }
    }

    string IntArrayToStr(int row, int column)
    {
        string a = "";
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                a = a + PetStatus[i][j].ToString() + '-';
                if (j == column - 1) a = a + '\n';
            }
        }
        return a;
    }

    void Start()
    {
        path = Path.Combine(Application.persistentDataPath, path);
        CoinPath = Path.Combine(Application.persistentDataPath, CoinPath);
        PetStatusPath = Path.Combine(Application.persistentDataPath, PetStatusPath);

        //コイン、クリアタイムを元にスコアを算出し、コイン、タイム、スコアをTMPで出力
        CoinText.text = RunPlayer.RunCoin.ToString();
        TimeText.text = RunTimeDisp.RunClearTime.ToString("f2");
        score = (50f - RunTimeDisp.RunClearTime) + (float)RunPlayer.RunCoin * (50f - RunTimeDisp.RunClearTime) * 0.2f;
        ScoreText.text = score.ToString("f2");

        string strDailyGameCount; //カウントは4まで
        strDailyGameCount = File.ReadAllText(path);
        int GameCount = strDailyGameCount[0] - '0'; //0*2
        if (GameCount <= 3)
        {
            GameCount++;
            GetCoinText.text = "\n10コインゲット！\n(本日あと" + (3 - GameCount).ToString() + "回)";

            NodeMaker.Coin += 10;
            File.WriteAllText(CoinPath, NodeMaker.Coin.ToString());

            string data = "";
            for (int i = 0; i < strDailyGameCount.Length; i += 2)
            {
                if (i == 0) data = data + GameCount.ToString() + '-';
                else data = data + strDailyGameCount[i] + '-';
            }
            File.WriteAllText(path, data);

            //熟練度アップ
            StrToIntArray(File.ReadAllText(PetStatusPath));
            PetStatus[GameSerectManager.GamePetType][3] += 2;
            PetStatus[GameSerectManager.GamePetType][4] -= 1;
            if (PetStatus[GameSerectManager.GamePetType][4] <= 0) PetStatus[GameSerectManager.GamePetType][4] = 0;
            PetStatus[GameSerectManager.GamePetType][5] -= 1;
            if (PetStatus[GameSerectManager.GamePetType][5] <= 0) PetStatus[GameSerectManager.GamePetType][5] = 0;
            File.WriteAllText(PetStatusPath, IntArrayToStr(3, 6));
        }
    }
}

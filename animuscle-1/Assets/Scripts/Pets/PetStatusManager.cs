using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using TMPro;

public class PetStatusManager : MonoBehaviour
{
    public TextMeshProUGUI text;

    string path = "PetStatus.txt";
    string PetPath = "PetUnlock.txt";

    int[][] PetStatus =
        {
            new int[6], //ペット1,配列0~2:腕,腹,脚ステータス,3~5:ゲーム1~3の熟練度
            new int[6], //ペット2
            new int[6] //ペット3
        };

    int dispray = 0; //表示中のペット番号

    public Sprite[] PetSprite;

    string PetUnlock;

    //ペットステータスのセーブデータを配列に変換
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

    //配列のペットステータスをセーブデータに変換
    string IntArrayToStr(int row, int column)
    {
        string a = "";
        for (int i = 0; i < row; i++)
        {
            for(int j = 0; j < column; j++)
            {
                a = a + PetStatus[i][j].ToString() + '-';
                if (j == column - 1) a = a + '\n';
            }
        }
        return a;
    }

    //表示する項目の設定
    void ShowStatus()
    {
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = PetSprite[dispray];
        text.text = "腕のちから：" + PetStatus[dispray][0] + "\n腹のちから：" + PetStatus[dispray][1] + "\n脚のちから：" + PetStatus[dispray][2];
        text.text+= "\nランゲームの熟練度：" + PetStatus[dispray][3] + "\nシューティングゲームの熟練度：" + PetStatus[dispray][4] + "\nバトルゲームの熟練度：" + PetStatus[dispray][5];
    }

    // Start is called before the first frame update
    void Start()
    {
        PetPath = Path.Combine(Application.persistentDataPath, PetPath);
        path = Path.Combine(Application.persistentDataPath, path);

        StrToIntArray(File.ReadAllText(path));
        //PetStatus[0][0] += 1;
        //File.WriteAllText(path, IntArrayToStr(3,6));
        PetUnlock = File.ReadAllText(PetPath);
        ShowStatus();
    }

    //1つ後のペットに変更
    public void ChangeRight()
    {
        dispray++;
        if (dispray == 3) dispray = 0;
        if (PetUnlock[dispray * 2] == '0') ChangeLeft();
        ShowStatus();
    }

    //1つ前のペットに変更
    public void ChangeLeft()
    {
        dispray--;
        if (dispray == -1) dispray = 2;
        if (PetUnlock[dispray * 2] == '0') ChangeRight();
        ShowStatus();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

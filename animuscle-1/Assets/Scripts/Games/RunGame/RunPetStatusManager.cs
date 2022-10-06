using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

//ペットのステータスを管理
public class RunPetStatusManager : MonoBehaviour
{
    public float arm; //腕ステータス
    public float abs; //腹ステータス
    public float leg; //脚ステータス

    string path = "PetStatus.txt";

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

    // Start is called before the first frame update
    void Start()
    {
        path = Path.Combine(Application.persistentDataPath, path);
        StrToIntArray(File.ReadAllText(path));
        arm = Calculation(PetStatus[GameSerectManager.GamePetType][0], PetStatus[GameSerectManager.GamePetType][3]);
        abs = Calculation(PetStatus[GameSerectManager.GamePetType][1], PetStatus[GameSerectManager.GamePetType][3]);
        leg = Calculation(PetStatus[GameSerectManager.GamePetType][2], PetStatus[GameSerectManager.GamePetType][3]);
    }

    float Calculation(int x, int proficiency)
    {
        //y=(-1/(x/100+1)+1)*100
        float y;
        y = (float)x / 100;
        y += 1f;
        y = -1f / y;
        y += 1f;
        y *= (100f + proficiency);
        return y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

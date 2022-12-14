using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class BattlePetStatusManager : MonoBehaviour
{
    string path = "PetStatus.txt";

    int[][] PetStatus =
        {
            new int[6], //?y?b?g1,?z??0~2:?r,??,?r?X?e?[?^?X,3~5:?Q?[??1~3?̏n???x
            new int[6], //?y?b?g2
            new int[6] //?y?b?g3
        };

    public float arm; //?r
    public float abs; //??
    public float leg; //?r

    void StrToIntArray(string strPetStatus)
    {
        int j = 0;
        int k = 0;
        int kari = 0;
        for (int i = 0; i < strPetStatus.Length; i++)
        {
            //ASCII??\n->10,\r->13,???s??windows??\r\n,mac??\n
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
        arm = Calculation(PetStatus[GameSerectManager.GamePetType][0], PetStatus[GameSerectManager.GamePetType][5]);
        abs = Calculation(PetStatus[GameSerectManager.GamePetType][1], PetStatus[GameSerectManager.GamePetType][5]);
        leg = Calculation(PetStatus[GameSerectManager.GamePetType][2], PetStatus[GameSerectManager.GamePetType][5]);

        PlayerController playerController;
        GameObject obj = GameObject.Find("Player");
        playerController = obj.GetComponent<PlayerController>();
        playerController.SetStatus(arm,abs,leg);
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

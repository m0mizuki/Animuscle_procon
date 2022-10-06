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
            new int[6], //�y�b�g1,�z��0~2:�r,��,�r�X�e�[�^�X,3~5:�Q�[��1~3�̏n���x
            new int[6], //�y�b�g2
            new int[6] //�y�b�g3
        };

    int dispray = 0; //�\�����̃y�b�g�ԍ�

    public Sprite[] PetSprite;

    string PetUnlock;

    //�y�b�g�X�e�[�^�X�̃Z�[�u�f�[�^��z��ɕϊ�
    void StrToIntArray(string strPetStatus)
    {
        int j = 0;
        int k = 0;
        int kari = 0;
        for (int i = 0; i < strPetStatus.Length; i++)
        {
            //ASCII��\n->10,\r->13,���s��windows��\r\n,mac��\n
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

    //�z��̃y�b�g�X�e�[�^�X���Z�[�u�f�[�^�ɕϊ�
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

    //�\�����鍀�ڂ̐ݒ�
    void ShowStatus()
    {
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = PetSprite[dispray];
        text.text = "�r�̂�����F" + PetStatus[dispray][0] + "\n���̂�����F" + PetStatus[dispray][1] + "\n�r�̂�����F" + PetStatus[dispray][2];
        text.text+= "\n�����Q�[���̏n���x�F" + PetStatus[dispray][3] + "\n�V���[�e�B���O�Q�[���̏n���x�F" + PetStatus[dispray][4] + "\n�o�g���Q�[���̏n���x�F" + PetStatus[dispray][5];
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

    //1��̃y�b�g�ɕύX
    public void ChangeRight()
    {
        dispray++;
        if (dispray == 3) dispray = 0;
        if (PetUnlock[dispray * 2] == '0') ChangeLeft();
        ShowStatus();
    }

    //1�O�̃y�b�g�ɕύX
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

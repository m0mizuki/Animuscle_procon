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
            new int[3], //�ڕW,0~2:�r���āA���؁A�X�N���b�g�̃Z�b�g��
            new int[3] //�B��������
        };

    int[] WeeklyGoalKari = new int[3];

    public GameObject WeeklyGoalWindow;

    public TextMeshProUGUI UdetateNumText;
    public TextMeshProUGUI HukkinNumText;
    public TextMeshProUGUI SquatNumText;

    public TextMeshProUGUI UdetateGoalText;
    public TextMeshProUGUI HukkinGoalText;
    public TextMeshProUGUI SquatGoalText;

    //�y�b�g�X�e�[�^�X�̃Z�[�u�f�[�^��z��ɕϊ�
    void StrToIntArray(string strWeeklyGoal)
    {
        int j = 0;
        int k = 0;
        int kari = 0;
        for (int i = 0; i < strWeeklyGoal.Length; i++)
        {
            //ASCII��\n->10,\r->13,���s��windows��\r\n,mac��\n
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

    //�z��̃y�b�g�X�e�[�^�X���Z�[�u�f�[�^�ɕϊ�
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

        //�\������e�L�X�g�̐ݒ�
        WeeklyGoalWindow.SetActive(false);
        StrToIntArray(File.ReadAllText(path));
        UdetateGoalText.text = "�ڕW��:" + WeeklyGoal[0][0].ToString() + "�Z�b�g\n�B����:" + WeeklyGoal[1][0].ToString() + "�Z�b�g";
        HukkinGoalText.text = "�ڕW��:" + WeeklyGoal[0][1].ToString() + "�Z�b�g\n�B����:" + WeeklyGoal[1][1].ToString() + "�Z�b�g";
        SquatGoalText.text = "�ڕW��:" + WeeklyGoal[0][2].ToString() + "�Z�b�g\n�B����:" + WeeklyGoal[1][2].ToString() + "�Z�b�g";
    }

    //�\������e�L�X�g���𔽉f
    void SetNumText()
    {
        UdetateNumText.text = WeeklyGoalKari[0].ToString();
        HukkinNumText.text = WeeklyGoalKari[1].ToString();
        SquatNumText.text = WeeklyGoalKari[2].ToString();
    }

    //WeeKGoalWindow���J����
    public void WeeKGoalWindowOpen()
    {
        for (int i = 0; i < 3; i++) WeeklyGoalKari[i] = WeeklyGoal[0][i];

        WeeklyGoalWindow.SetActive(true);
        SetNumText();
    }

    //WeeKGoalWindow�����
    public void WeekGoalWindowClose(bool save)
    {
        WeeklyGoalWindow.SetActive(false);
        //�Z�[�u
        if (save)
        {
            for (int i = 0; i < 3; i++) WeeklyGoal[0][i] = WeeklyGoalKari[i];
            File.WriteAllText(path, IntArrayToStr(2, 3));
        }
        UdetateGoalText.text = "�ڕW��:" + WeeklyGoal[0][0].ToString() + "�Z�b�g\n�B����:" + WeeklyGoal[1][0].ToString() + "�Z�b�g";
        HukkinGoalText.text = "�ڕW��:" + WeeklyGoal[0][1].ToString() + "�Z�b�g\n�B����:" + WeeklyGoal[1][1].ToString() + "�Z�b�g";
        SquatGoalText.text = "�ڕW��:" + WeeklyGoal[0][2].ToString() + "�Z�b�g\n�B����:" + WeeklyGoal[1][2].ToString() + "�Z�b�g";
    }

    //�����𑝂₷
    public void AddNum(int type) 
    {
        WeeklyGoalKari[type]++;
        if (WeeklyGoalKari[type] > 99) WeeklyGoalKari[type] = 99;
        SetNumText();
    }

    //���������炷
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

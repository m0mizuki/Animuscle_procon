using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using TMPro;
using UnityEngine.SceneManagement;

public class GameSerectManager : MonoBehaviour
{
    public static int GamePetType;

    public TextMeshProUGUI GameNameText;
    public TextMeshProUGUI GameExplanationText;
    public TextMeshProUGUI ProficiencyText;

    string path = "PetStatus.txt";
    string PetPath = "PetUnlock.txt";

    int[][] PetStatus =
        {
            new int[6], //�y�b�g1,�z��0~2:�r,��,�r�X�e�[�^�X,3~5:�Q�[��1~3�̏n���x
            new int[6], //�y�b�g2
            new int[6] //�y�b�g3
        };

    string[] PetName = { "�N�}", "�T��", "�X�V" };
    string[] GameName = { "�A�N�V�����Q�[��", "�V���[�e�B���O�Q�[��", "�o�g���Q�[��" };
    string[] GameExplanation =
    {
        "�y�b�g�̃X�e�[�^�X�{�[�i�X\n���r�̂����灄\n����X�s�[�h�A�b�v\n�����̂����灄\n���A�ɂ����鎞�ԒZ�k\n���r�̂����灄\n����X�s�[�h�ƃW�����v�̓A�b�v",
        "�y�b�g�̃X�e�[�^�X�{�[�i�X\n���r�̂����灄\n�e�̔��˃N�[���^�C���Z�k\n�����̂����灄\n�G�̈ړ����x�Əo���Ԋu�A�b�v\n���r�̂����灄\n���g�̈ړ����x�A�b�v",
        "�y�b�g�̃X�e�[�^�X�{�[�i�X\n���r�̂����灄\n���g�̍U���̓A�b�v\n�����̂����灄\n���g��HP�A�b�v\n���r�̂����灄\n���g�̍U���p�x�A�b�v"
    };

    int SelectingPet = 0; //�\�����̃y�b�g�ԍ�
    int SelectingGame = 0; //�I�𒆂̃Q�[���ԍ�

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
        PetPath = Path.Combine(Application.persistentDataPath, PetPath);
        path = Path.Combine(Application.persistentDataPath, path);

        //�f�[�u�f�[�^�̃��[�h
        StrToIntArray(File.ReadAllText(path));
        PetUnlock = File.ReadAllText(PetPath);
        SetPetExplanation();
        SetGameExplanation();
    }

    //�I�����Ă���y�b�g�ύX���̌����ڂ̔��f
    void SetPetExplanation()
    {
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = PetSprite[SelectingPet];
        ProficiencyText.text = PetName[SelectingPet] + "��" + GameName[SelectingGame] + "\n�̏n���x:" + PetStatus[SelectingPet][SelectingGame + 3];
    }

    //�I�����Ă���Q�[���ύX���̌����ڂ̔��f
    void SetGameExplanation()
    {
        GameNameText.text = GameName[SelectingGame];
        GameExplanationText.text = GameExplanation[SelectingGame];
        ProficiencyText.text = PetName[SelectingPet] + "��" + GameName[SelectingGame] + "\n�̏n���x:" + PetStatus[SelectingPet][SelectingGame + 3];
    }

    //���ɂ���y�b�g��I��
    public void ChangePetRight()
    {
        SelectingPet++;
        if (SelectingPet == 3) SelectingPet = 0;
        if (PetUnlock[SelectingPet * 2] == '0') ChangePetRight();
        SetPetExplanation();
    }

    //�O�ɂ���y�b�g��I��
    public void ChangePetLeft()
    {
        SelectingPet--;
        if (SelectingPet == -1) SelectingPet = 2;
        if (PetUnlock[SelectingPet * 2] == '0') ChangePetLeft();
        SetPetExplanation();
    }

    //���ɂ���Q�[����I��
    public void ChangeGameRight()
    {
        SelectingGame++;
        if (SelectingGame == 3) SelectingGame = 0;
        SetGameExplanation();
    }

    //�O�ɂ���Q�[����I��
    public void ChangeGameLeft()
    {
        SelectingGame--;
        if (SelectingGame == -1) SelectingGame = 2;
        SetGameExplanation();
    }

    //�Q�[���X�^�[�g�{�^���������ꂽ�Ƃ��̏���
    public void PushPlay()
    {
        GamePetType = SelectingPet;
        if (SelectingGame == 0) SceneManager.LoadScene("RunStart");
        if (SelectingGame == 1) SceneManager.LoadScene("ShootingStart");
        if (SelectingGame == 2) SceneManager.LoadScene("BattleStart");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

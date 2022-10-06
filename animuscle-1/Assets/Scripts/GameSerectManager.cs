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
            new int[6], //ペット1,配列0~2:腕,腹,脚ステータス,3~5:ゲーム1~3の熟練度
            new int[6], //ペット2
            new int[6] //ペット3
        };

    string[] PetName = { "クマ", "サメ", "スシ" };
    string[] GameName = { "アクションゲーム", "シューティングゲーム", "バトルゲーム" };
    string[] GameExplanation =
    {
        "ペットのステータスボーナス\n＜腕のちから＞\n走るスピードアップ\n＜腹のちから＞\n復帰にかかる時間短縮\n＜脚のちから＞\n走るスピードとジャンプ力アップ",
        "ペットのステータスボーナス\n＜腕のちから＞\n弾の発射クールタイム短縮\n＜腹のちから＞\n敵の移動速度と出現間隔アップ\n＜脚のちから＞\n自身の移動速度アップ",
        "ペットのステータスボーナス\n＜腕のちから＞\n自身の攻撃力アップ\n＜腹のちから＞\n自身のHPアップ\n＜脚のちから＞\n自身の攻撃頻度アップ"
    };

    int SelectingPet = 0; //表示中のペット番号
    int SelectingGame = 0; //選択中のゲーム番号

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

        //デーブデータのロード
        StrToIntArray(File.ReadAllText(path));
        PetUnlock = File.ReadAllText(PetPath);
        SetPetExplanation();
        SetGameExplanation();
    }

    //選択しているペット変更時の見た目の反映
    void SetPetExplanation()
    {
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = PetSprite[SelectingPet];
        ProficiencyText.text = PetName[SelectingPet] + "の" + GameName[SelectingGame] + "\nの熟練度:" + PetStatus[SelectingPet][SelectingGame + 3];
    }

    //選択しているゲーム変更時の見た目の反映
    void SetGameExplanation()
    {
        GameNameText.text = GameName[SelectingGame];
        GameExplanationText.text = GameExplanation[SelectingGame];
        ProficiencyText.text = PetName[SelectingPet] + "の" + GameName[SelectingGame] + "\nの熟練度:" + PetStatus[SelectingPet][SelectingGame + 3];
    }

    //次にあるペットを選択
    public void ChangePetRight()
    {
        SelectingPet++;
        if (SelectingPet == 3) SelectingPet = 0;
        if (PetUnlock[SelectingPet * 2] == '0') ChangePetRight();
        SetPetExplanation();
    }

    //前にあるペットを選択
    public void ChangePetLeft()
    {
        SelectingPet--;
        if (SelectingPet == -1) SelectingPet = 2;
        if (PetUnlock[SelectingPet * 2] == '0') ChangePetLeft();
        SetPetExplanation();
    }

    //次にあるゲームを選択
    public void ChangeGameRight()
    {
        SelectingGame++;
        if (SelectingGame == 3) SelectingGame = 0;
        SetGameExplanation();
    }

    //前にあるゲームを選択
    public void ChangeGameLeft()
    {
        SelectingGame--;
        if (SelectingGame == -1) SelectingGame = 2;
        SetGameExplanation();
    }

    //ゲームスタートボタンが押されたときの処理
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

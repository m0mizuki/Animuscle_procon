
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine.SceneManagement;
using NatSuite.Sharing;
using System;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.Linq;



public class KintoreManager : MonoBehaviour
{
    //バイブレーション用処理
    [DllImport("__Internal")]
    private static extern void audioServicePlaySystemSound(int soundId);

    public static void PlaySystemSound(int soundId)
    {
#if !UNITY_EDITOR && UNITY_IOS
        audioServicePlaySystemSound(soundId);
#endif
    }

    public GameObject changescene;
    public GameObject clearPanel;
    public TextMeshProUGUI clearText;
    public GameObject overPanel;
    public GameObject TimeText;
    public GameObject tempoPanel;
    public GameObject formPanel;


    public GameObject tutorialPanel;
    public TextMeshProUGUI tutorialText;
    public Image tutorialImage;

    //チュートリアル用
    int tutorialPage = 0;
    public Sprite[] images = new Sprite[9];
    string[] tTexts = new string[] {
        "　手を肩幅よりやや広くし\n　姿勢を維持するため\n　腹筋に力を入れます\n          1/3",
        "ひじを曲げ胸を床に近づけ\nいったん静止した後、\n最初の姿勢に戻ります\n          2/3",
        "　スマートフォンを下向きで\n　胸の前に\n　着用してください\n          3/3",
        "仰向けになりひざを立てます\nそして、両手を\n頭の後ろに添えます\n          1/3",
        "　息を吐きながら上半身を\n　持ち上げ、その後\n　最初の姿勢に戻ります\n          2/3",
                "　スマートフォンを下向きで\n　胸の前に\n　着用してください\n          3/3",
        "　両足を肩幅ほどに開き\n　両足を前に伸ばします\n\n          1/3",
        "ひざが直角になるまで\n腰を落とし、その後\n最初の姿勢に戻ります\n          2/3",
        "　スマートフォンを下向きで\n　左の太ももの外側に\n　着用してください\n          3/3"
    };
    public TextMeshProUGUI nextPagetext;

    public GameObject backPanel;

    public GameObject CountPanel;
    public TextMeshProUGUI countText;
    int countDown = 3;
    bool startFalg = false;

    //記録ファイルのパス
    string pathX = "Assets/history/x.txt";
    string pathY = "Assets/history/y.txt";
    string pathZ = "Assets/history/z.txt";

    //スマートフォンの加速度を獲得
    float slopeX = 0;
    float slopeY = 0;
    float slopeZ = 0;

    string[] totalPath = new string[]{
        "udetate_t.txt",
        "hukkin_t.txt",
        "sukuwatto_t.txt",
        "danberu_t.txt"
    };

    string petStatus = "PetStatus.txt";

    public TextAsset udetate_t;
    public TextAsset hukkin_t;
    public TextAsset sukuwatto_t;

    string historyPath = "history.txt";

    public static int count = 0;

    float timer;
    float slope = 0.0f;

    bool downFlag = false;
    bool upFlag = false;
    bool finishFlag = false;
    int kaisuu;
    int score;
    bool loopFlag;

    float upMax, upMin;
    float downMax, downMin;

    bool historyFlag = false;


    int kintoreKind;
    string kintoreKindText;

    string resultPath = null;



    //筋トレのボーナスポイントを判定
    bool overWorkFlag = false;
    int squatOver;
    bool bureFlag = false;
    float[] kintoreTime = new float[10];
    bool badFormFlag = false;

    float beforTime;
    //int time[KintoreChangeScene.kaisuu];

    StreamReader sr = null;
    DateTime dt;
    int j = 0;


    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            totalPath[i] = Path.Combine(Application.persistentDataPath, totalPath[i]);
        }

        petStatus = Path.Combine(Application.persistentDataPath, petStatus);
        historyPath = Path.Combine(Application.persistentDataPath, historyPath);
        beforTime = Time.realtimeSinceStartup;

        count = 0;
        downFlag = false;
        upFlag = false;
        loopFlag = false;
        timer = Time.time;
        clearPanel.SetActive(false);
        overPanel.SetActive(false);
        tempoPanel.SetActive(false);
        formPanel.SetActive(false);

        kaisuu = 10;

        kintoreKind = KintoreChangeScene.Kintore;

        tutorialPage = kintoreKind * 3;




        switch (kintoreKind)//筋トレに合わせて数値を調整
        {

            case 0://腕立て
                resultPath = "udetate.txt";
                upMin = 90;
                upMax = 120;

                downMax = 60;
                kintoreKindText = "腕立て伏せ";
                break;
            case 1://腹筋
                resultPath = "hukkin.txt";
                upMin = 80;
                upMax = 110;

                downMax = 0;

                kintoreKindText = "腹筋";
                break;
            case 2://スクワット
                upMin = 65;
                upMax = 100;

                downMax = 30;
                squatOver = -10;
                kintoreKindText = "スクワット";
                resultPath = "sukuwatto.txt";
                break;

            case 3: //ダンベル
                upMin = 65;
                upMax = 100;

                downMax = 30;
                kintoreKindText = "ダンベル";
                resultPath = "udetate.txt";
                break;
            default:
                UnityEngine.Debug.Log("無効なトレーニング");
                break;
        }
        resultPath = Path.Combine(Application.persistentDataPath, resultPath);
        if (kintoreKind == 3)
            tutorialPanel.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (startFalg == false && kintoreKind != 3)
            tutorial();
        else if (loopFlag == false)
            startCount();




        if (loopFlag)
        {
            slopeX = Mathf.Floor(Input.acceleration.x * 180f / Mathf.PI * 1.5f);
            slopeY = Mathf.Floor(Input.acceleration.y * 180f / Mathf.PI * 1.5f);
            slopeZ = Mathf.Floor(Input.acceleration.z * 180f / Mathf.PI * 1.5f);

            switch (kintoreKind)//筋トレに合わせて数値を調整
            {

                case 0://腕立て
                    slope = slopeZ;

                    if (slopeX > 20 || slopeX < -40)
                        badFormFlag = true;
                    break;
                case 1://腹筋
                    slope = slopeY;

                    if (slopeX > 25 || slopeX < -20)
                        badFormFlag = true;

                    break;
                case 2://スクワット
                    slope = slopeY;

                    if (slopeZ > 30 || slopeZ < -15)
                        badFormFlag = true;

                    break;
                case 3:

                    slopeX = ConsoleOutput.AngleDataESP[0];
                    slopeY = ConsoleOutput.AngleDataESP[1];
                    slopeZ = ConsoleOutput.AngleDataESP[2];
                    break;
                default:
                    UnityEngine.Debug.Log("無効なトレーニング");
                    break;
            }



            if ((kintoreKind == 2) && (slope < squatOver))
            {

                overWorkFlag = true;
            }
            //UnityEngine.Debug.Log(slope);


            if (slope > upMin && slope < upMax)
            {
                UnityEngine.Debug.Log("lpop");
                if (downFlag == true)
                {
                    kintoreTime[j] = Time.realtimeSinceStartup - beforTime;
                    beforTime = Time.realtimeSinceStartup;
                    j++;
                    count += 1;
                    PlaySystemSound(1350);
                    downFlag = false;
                }
                upFlag = true;
            }
            else if (slope < downMin)
            {
                if (upFlag == true)
                {
                    PlaySystemSound(1350);
                    downFlag = true;
                    upFlag = false;
                }

            }

            if (count >= kaisuu && finishFlag == false) //筋トレを指定回数行うと終了
            {
                loopFlag = false;
                finishFlag = true;
                finishKintore();
            }
            /*
            if(count % 10 == 0)
            {
                if(historyFlag == false)
                {
                    File.AppendAllText(pathX,"/\n");
                    File.AppendAllText(pathY,"/\n");
                    File.AppendAllText(pathZ,"/\n");
                    historyFlag = true;
                }
                File.AppendAllText(pathX, slopeX + "\n");
                File.AppendAllText(pathY, slopeY + "\n");
                File.AppendAllText(pathZ, slopeZ + "\n");
            }
            */
            if (count % 11 == 0 && historyFlag == true)
            {
                historyFlag = false;
            }
        }
    }

    public void PushDebugButton()//筋トレ回数カウントを進める:デバッグ用
    {
        kintoreTime[j] = Time.realtimeSinceStartup - beforTime;
        beforTime = Time.realtimeSinceStartup;
        j++;
        count++;
    }
    public void PushOverFlag()
    {
        overWorkFlag = true;
    }

    void finishKintore()//筋トレ終了時の処理
    {
        PlaySystemSound(1011);
        timer = (Time.time - timer);
        clearPanel.SetActive(true);
        score = kaisuu;

        if (overWorkFlag == true)
        {
            overPanel.SetActive(true);
        }


        checkTempo();
        if (bureFlag == false)
        {
            tempoPanel.SetActive(true);
            score += 3;
        }

        if (badFormFlag == false)
        {
            formPanel.SetActive(true);
            score += 3;
        }



        clearText.text = kintoreKindText + "　のポイントを\n" + score + "ポイント獲得しました";

        TimeText.GetComponent<TextMeshProUGUI>().text = (timer.ToString("f2") + "s");
        int kintorePoint = 0;
        string[] kintoreTe = new string[2];

        int x = 0, y = 0;

        if (!File.Exists(resultPath))
        {
            File.WriteAllText(resultPath, score.ToString() + Environment.NewLine);
        }
        else
        {
            kintoreTe = File.ReadAllText(resultPath).Split('\n');
            int kp;
            kp = score + int.Parse(kintoreTe[0]);
            File.WriteAllText(resultPath, kp.ToString() + Environment.NewLine);
        }

        //各ペットにポイントを代入
        //File.WriteAllText(petStatus, "0-0-0-0-0-0-\n0-0-0-0-0-0-\n0-0-0-0-0-0-"); 
        UnityEngine.Debug.Log(File.ReadAllText(petStatus));
        string petText = File.ReadAllText(petStatus);
        int textLength = File.ReadAllText(petStatus).Length;
        char[] pts = new char[textLength];
        pts = petStatus.ToCharArray();

        int statusSppot;
        if (kintoreKind != 3)
            statusSppot = kintoreKind + KintoreChangeScene.KintorePetType * 6;
        else
            statusSppot = 0 + KintoreChangeScene.KintorePetType * 6;
        char[] del = { '-' };

        string[] arr = petText.Split(del);

        arr[statusSppot] = (int.Parse(arr[statusSppot]) + score).ToString();

        UnityEngine.Debug.Log(":" + score + ":" + arr[statusSppot]); ;

        File.WriteAllText(petStatus, "");
        for (int i = 0; i < 18; i++)
        {
            if (i % 6 != 0)
            {
                File.AppendAllText(petStatus, arr[i] + "-");
            }
            else
            {
                //File.AppendAllText(petStatus, "\n");
                File.AppendAllText(petStatus, arr[i] + "-");
            }
        }


        long unixTimestamp = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        File.AppendAllText(resultPath, unixTimestamp.ToString());
        dt = DateTime.Now;


        if (!File.Exists(historyPath))
        {
            File.WriteAllText(historyPath, kintoreKind + "\n" + unixTimestamp + "\n" + kaisuu + "\n");
        }
        else
        {
            File.AppendAllText(historyPath, kintoreKind + "\n" + unixTimestamp + "\n" + kaisuu + "\n");
        }



        int totalKaisuu;
        totalKaisuu = kaisuu;





        if (!File.Exists(totalPath[kintoreKind]))
        {
            File.WriteAllText(totalPath[kintoreKind], totalKaisuu.ToString());
        }
        else
        {
            totalKaisuu += int.Parse(File.ReadAllText(totalPath[kintoreKind]));
            File.WriteAllText(totalPath[kintoreKind], totalKaisuu.ToString());
        }


    }

    void checkTempo()//テンポボーナスの確認
    {


        float sum = 0;
        float ave = 0;

        float bure = 0;

        for (int i = 1; i < 10; i++)
        {
            sum += kintoreTime[i];
            UnityEngine.Debug.Log(kintoreTime[i]);
        }
        ave = sum / 9.0f;
        UnityEngine.Debug.Log("ave : " + ave);
        for (int i = 1; i < 10; i++)
        {
            bure = (ave - kintoreTime[i]) / ave * 100; //何%のぶれか検証
            UnityEngine.Debug.Log("p" + ":" + bure);
            if (bure > 200)
                bureFlag = true;
            if (bure < -200)
                bureFlag = true;

        }
    }

    public void ShareString() //シェア用の関数
    {
        var payload = new SharePayload();
        payload.AddText(KintoreText.kintoreKind + "を" + kaisuu + "回しました");
        payload.Commit();
    }

    void tutorial() //チュートリアルを開始
    {
        tutorialImage.sprite = images[tutorialPage];
        tutorialText.text = tTexts[tutorialPage];
    }

    public void nextPage() //チュートリアルページを進める
    {
        if (tutorialPage == kintoreKind * 3 + 2)
        {
            tutorialPanel.SetActive(false);
            startFalg = true;
            //UnityEngine.Debug.Log("bbb");

        }
        else
            tutorialPage++;

        if (tutorialPage == kintoreKind * 3 + 2)
            nextPagetext.text = "筋トレを始める";
        //UnityEngine.Debug.Log(tutorialPage);

    }

    public void backPage() //チュートリアルページを戻る
    {
        if (tutorialPage == kintoreKind * 3)
        {
            backPanel.SetActive(true);
        }
        else if (tutorialPage > 0)
            tutorialPage--;

        nextPagetext.text = "次のページ";

    }



    //筋トレ開始前のカウントダウン
    float time = 4;
    void startCount()
    {
        time -= Time.deltaTime;
        countDown = (int)time;
        countText.text = countDown.ToString();
        //UnityEngine.Debug.Log("countDown");
        if (countDown == 0)
        {
            CountPanel.SetActive(false);
            loopFlag = true;
        }


    }

    public void pauseKintore() //筋トレを中断
    {
        backPanel.SetActive(true);
    }

    //中断画面から筋トレに戻る
    public void backKintore()
    {
        backPanel.SetActive(false);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;


public class TimeManager : MonoBehaviour
{
    const int kintoreKazu = 3;

    string udetatePath = "Assets/history/udetate.txt";
    string hukkinPath = "Assets/history/hukkin.txt";
    string sukuwattoPath = "Assets/history/sukuwatto.txt";

    string[] path = new string[kintoreKazu];

    

    int[] status = new int[kintoreKazu];
    long[] time = new long[kintoreKazu];
    long nowTime;
    StreamReader sr;
    // Start is called before the first frame update
    void Start()
    {
        path[0] = udetatePath;
        path[1] = hukkinPath;
        path[2] = sukuwattoPath;

        for(int i = 0;i < kintoreKazu;i++)
        {
            var fs = new FileStream(
                path[i], FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            sr = new StreamReader(fs);

            status[i] = int.Parse(sr.ReadLine());
            time[i] = int.Parse(sr.ReadLine());
        }
    }

    // Update is called once per frame
    void Update()
    {
        nowTime = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        checkDonwStatus();
    }

    void checkDonwStatus()
    {
        int downInterval = 60;
        for (int i = 0; i < kintoreKazu; i++)
        {
            if(downInterval < (nowTime - time[i]))
            {
                status[i] = (int)(status[i] * 0.9f);
                time[i] = nowTime;
                File.WriteAllText(path[i], status[i].ToString() + Environment.NewLine);
                File.AppendAllText(path[i], nowTime.ToString());
                UnityEngine.Debug.Log(path[i] + " was changed");
            }


        }
    }
}

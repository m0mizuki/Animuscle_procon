using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class StartGame : MonoBehaviour
{
    string PetStatus = "PetStatus.txt";
    string PetPathUnlock = "PetUnlock.txt";
    string weeklyGoal = "WeeklyGoal.txt";
    string UseDate = "UseDate.txt";
    string CoinPath = "coin.txt";
    string DailyGameCountPath = "DailyGameCount.txt";


    // Start is called before the first frame update
    void Start()
    {
        madeFile(PetStatus, "0-0-0-0-0-0-\n0-0-0-0-0-0-\n0-0-0-0-0-0-");
        madeFile(PetPathUnlock, "1-0-0-");
        madeFile(weeklyGoal, "5-5-5-\n0-0-0-");
        madeFile(UseDate, "03110");
        madeFile(CoinPath, "10");
        madeFile(DailyGameCountPath, "0-0-0-");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void madeFile(string path,string naiyou)
    {
        path = Path.Combine(Application.persistentDataPath,path);
        if(!File.Exists(path))
        {
            File.WriteAllText(path,naiyou);
        }
    }
}

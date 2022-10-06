using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using TMPro;

public class AdvancedSetting : MonoBehaviour
{

    string UseDatePath = "UseDate.txt";
    string PetStatusPath = "PetStatus.txt";
    string PetPath = "PetUnlock.txt";
    string CoinPath = "coin.txt";

    public GameObject CoinInput;
    public GameObject PetUnlockInputA;
    public GameObject PetUnlockInputB;
    public GameObject[] PetStatusInput;
    public GameObject UseDateInput;

    // Start is called before the first frame update
    void Start()
    {
        UseDatePath = Path.Combine(Application.persistentDataPath, UseDatePath);
        PetStatusPath = Path.Combine(Application.persistentDataPath, PetStatusPath);
        PetPath = Path.Combine(Application.persistentDataPath, PetPath);
        CoinPath = Path.Combine(Application.persistentDataPath, CoinPath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSetting()
    {
        bool TrueData = true;
        string PetStatusData = "";
        for (int i= 0; i < 18; i++)
        {
            PetStatusData += PetStatusInput[i].GetComponent<TMP_InputField>().text + "-";
            if (i == 5 || i == 11) PetStatusData += "\n";
            if (PetStatusInput[i].GetComponent<TMP_InputField>().text == "") TrueData = false;
        }
        if(TrueData)File.WriteAllText(PetStatusPath, PetStatusData);

        string PetUnlockData;
        PetUnlockData = "1-" + PetUnlockInputA.GetComponent<TMP_InputField>().text + "-" + PetUnlockInputB.GetComponent<TMP_InputField>().text + "-";
        if (PetUnlockData.Length == 6) File.WriteAllText(PetPath, PetUnlockData);

        if (CoinInput.GetComponent<TMP_InputField>().text != "") File.WriteAllText(CoinPath, CoinInput.GetComponent<TMP_InputField>().text);

        if (UseDateInput.GetComponent<TMP_InputField>().text.Length == 5) File.WriteAllText(UseDatePath, UseDateInput.GetComponent<TMP_InputField>().text);
    }
}

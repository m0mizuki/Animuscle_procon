using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.IO;

public class NodeMaker : MonoBehaviour
{
    public GameObject Node;

    string path = "PetUnlock.txt";
    string pathCoin = "coin.txt";

    public static int Coin;

    public TextMeshProUGUI CoinValue;

    // Start is called before the first frame update
    void Start()
    {
        path = Path.Combine(Application.persistentDataPath, path);
        pathCoin = Path.Combine(Application.persistentDataPath, pathCoin);
        string strCoin = File.ReadAllText(pathCoin);
        //テキストデータからコインデータを抽出
        Coin = 0;
        for(int i=0; i<strCoin.Length; i++)
        {
            Coin = Coin * 10 + strCoin[i] - '0';
        }
        CoinValue.text = Coin.ToString();

        //ショップの項目を生成
        for (int num = 0; num < 6; num++)
        {
            bool MakeNode = false;
            string PetUnlock = File.ReadAllText(path);
            if (num == 0 && PetUnlock[0] == '1') MakeNode = true;
            if (num == 1 && PetUnlock[2] == '1') MakeNode = true;
            if (num == 2 && PetUnlock[4] == '1') MakeNode = true;
            if (num == 3 && PetUnlock[2] == '0') MakeNode = true;
            if (num == 4 && PetUnlock[4] == '0') MakeNode = true;
            if (num == 5 && !ShareController.CanCanmera) MakeNode = true;
            if (MakeNode)
            {
                GameObject newNode = (GameObject)Instantiate(Node, Vector3.zero, Quaternion.identity);
                newNode.transform.SetParent(this.transform, false); //falseでuiあつかいになる
                NodeManager n = newNode.GetComponent<NodeManager>();
                n.Create(num);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

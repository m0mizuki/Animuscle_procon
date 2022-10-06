using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class ItemUsing : MonoBehaviour
{

    public static Vector3 applePos = new Vector3(99, 99, 99); //(99,99,99)で存在しないサイン

    public GameObject Apple;
    public GameObject Pet;

    public static int FruitType;

    public static int CanMakingApple = 0; //リンゴなどを生成できるフラグ

    string path = "PetUnlock.txt";

    // Start is called before the first frame update
    void Start()
    {
        path = Path.Combine(Application.persistentDataPath,path);
        string PetUnlock = File.ReadAllText(path);
        for (int i = 0; i < 3; i++)
        {
            //Debug.Log(PetUnlock[i * 2]);
            if (PetUnlock[i * 2] == '1')
            {
                GameObject newPet;
                if (i == 0)
                {
                    newPet = (GameObject)Instantiate(Pet, new Vector3(0, -1, 0), Quaternion.identity); //位置決め
                    GameObject child = newPet.transform.Find("PetMain").gameObject; //子オブジェクトであるPetMainにスクリプトがあるのでPetMainを取得
                    PetsMoving p = child.GetComponent<PetsMoving>();
                    p.Create(i);
                }
                if (i == 1)
                {
                    newPet = (GameObject)Instantiate(Pet, new Vector3(-1, 1, 0), Quaternion.identity);
                    GameObject child = newPet.transform.Find("PetMain").gameObject;
                    PetsMoving p = child.GetComponent<PetsMoving>();
                    p.Create(i);
                }
                if (i == 2)
                {
                    newPet = (GameObject)Instantiate(Pet, new Vector3(1, 1, 0), Quaternion.identity);
                    GameObject child = newPet.transform.Find("PetMain").gameObject;
                    PetsMoving p = child.GetComponent<PetsMoving>();
                    p.Create(i);
                }
            }
        }

        if (CanMakingApple == 0)
        {
            FruitType = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //ボタンが押されたかつ、果物を生成可能なとき、果物を生成
        if (Input.GetMouseButtonDown(0) && CanMakingApple != 0)
        {
            applePos.x = Input.mousePosition.x / 750 * 4.64f - 2.32f;
            applePos.y = Input.mousePosition.y / 1334 * 10.0f - 5.0f;

            GameObject newApple = (GameObject)Instantiate(Apple, new Vector3(applePos.x, applePos.y, 2), Quaternion.identity);
            AppleMoving a = newApple.GetComponent<AppleMoving>();
            a.Create(CanMakingApple);

            FruitType = CanMakingApple;
            CanMakingApple = 0;
        }
    }
}

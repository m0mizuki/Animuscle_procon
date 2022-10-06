using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class ItemUsing : MonoBehaviour
{

    public static Vector3 applePos = new Vector3(99, 99, 99); //(99,99,99)�ő��݂��Ȃ��T�C��

    public GameObject Apple;
    public GameObject Pet;

    public static int FruitType;

    public static int CanMakingApple = 0; //�����S�Ȃǂ𐶐��ł���t���O

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
                    newPet = (GameObject)Instantiate(Pet, new Vector3(0, -1, 0), Quaternion.identity); //�ʒu����
                    GameObject child = newPet.transform.Find("PetMain").gameObject; //�q�I�u�W�F�N�g�ł���PetMain�ɃX�N���v�g������̂�PetMain���擾
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
        //�{�^���������ꂽ���A�ʕ��𐶐��\�ȂƂ��A�ʕ��𐶐�
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

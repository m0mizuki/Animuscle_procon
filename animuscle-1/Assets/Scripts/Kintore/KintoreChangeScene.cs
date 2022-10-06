using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;
using System.IO;

public class KintoreChangeScene : MonoBehaviour
{
    
    string PetUnlock;

    public Sprite[] PetSprite; //ペットの見た目

    int SelectingPet = 0; //表示中のペット番号

    string PetPath = "PetUnlock.txt";

    public static int KintorePetType = 0; //筋トレに連れてくペット

    public static int Kintore = 0; //行う筋トレの種類
    /* 0:腕立て
     * 1:腹筋
     * 2:スクワット
     */
    public static int kaisuu = 10;//1セットの回数

    public TextMeshProUGUI tmp;

    private void Start()
    {
        PetPath = Path.Combine(Application.persistentDataPath, PetPath);
        PetUnlock = File.ReadAllText(PetPath);
        
    }

    private void Update()
    {
        tmp.text = kaisuu.ToString();
    }

    public void GoKintore(int kintore)
    {
        //筋トレの種類を変更し、筋トレのシーンへ進む
        Kintore = kintore;
        KintorePetType = SelectingPet;
        SceneManager.LoadScene("TrainingScene");
    }

    public void IncreaseKaisuu(int x)
    {
        if (kaisuu + x <= 50)
            kaisuu += x;
    }

    public void ReduceKaisuu(int x)
    {
        if (kaisuu - x >= 10)
            kaisuu -= x;
    }

    public void ChangePetRight()
    {
        SelectingPet++;
        if (SelectingPet == 3) SelectingPet = 0;
        if (PetUnlock[SelectingPet * 2] == '0') ChangePetRight();
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = PetSprite[SelectingPet];
    }

    public void ChangePetLeft()
    {
        SelectingPet--;
        if (SelectingPet == -1) SelectingPet = 2;
        if (PetUnlock[SelectingPet * 2] == '0') ChangePetLeft();
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = PetSprite[SelectingPet];
    }
}

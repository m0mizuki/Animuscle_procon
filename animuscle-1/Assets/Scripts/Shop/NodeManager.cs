using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;
using System.IO;
using UnityEngine.UI;

public class NodeManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    int MyNumber;

    string path = "PetUnlock.txt";
    string CoinPath = "coin.txt";

    //�V���b�v�A�C�e���̐�����
    string[] NodeText =
    {
        "�����S\n�N�}�̍D��",
        "�C�`�S\n�T���̍D��",
        "�o�i�i\n�X�V�̍D��",
        "�T��\n�V�����y�b�g",
        "�X�V\n�V�����y�b�g",
        "�C���X�^���g�J����\n�y�b�g�̃X�N���[���V���b�g���B����twitter�ɋ��L�ł���B",
        "�G���["
    };

    int[] price = { 10, 10, 10, 300, 300, 20 };

    //�C���[�W
    public Sprite image1;
    public Sprite image2;
    public Sprite image3;
    public Sprite image4;
    public Sprite image5;
    public Sprite image6;

    public Button BuyButton;

    public TextMeshProUGUI PriceText;

    public GameObject child;

    public void Create(int num)
    {
        //���g�̔ԍ��̌����ڂ�I��
        MyNumber = num;
        text.text = NodeText[num];
        
        Image img = child.GetComponent<Image>();
        if (num == 0) img.sprite = image1;
        if (num == 1) img.sprite = image2;
        if (num == 2) img.sprite = image3;
        if (num == 3) img.sprite = image4;
        if (num == 4) img.sprite = image5;
        if (num == 5) img.sprite = image6;

        PriceText.text = price[MyNumber].ToString();

        if (price[MyNumber] > NodeMaker.Coin) BuyButton.interactable = false;
    }

    //�Z�[�u�f�[�^���쐬
    string MakeUnlockData(string str, int num)
    {
        string data = "";
        for (int i = 0; i < str.Length; i += 2)
        {
            if (i == (num - 1) * 2) data = data + "1-";
            else data = data + str[i] + '-';
        }
        return data;
    }

    //�w���{�^���������ꂽ�Ƃ��̏���
    public void PushedBuyButton()
    {
        NodeMaker.Coin -= price[MyNumber];
        File.WriteAllText(CoinPath, NodeMaker.Coin.ToString());

        if (MyNumber == 0 || MyNumber == 1 || MyNumber == 2) ItemUsing.CanMakingApple = MyNumber + 1;
        if (MyNumber == 3)
        {
            string PetUnlock = File.ReadAllText(path);
            File.WriteAllText(path, MakeUnlockData(PetUnlock, 2));
        }
        if (MyNumber == 4)
        {
            string PetUnlock = File.ReadAllText(path);
            File.WriteAllText(path, MakeUnlockData(PetUnlock, 3));
        }
        if (MyNumber == 5) ShareController.CanCanmera = true;
        SceneManager.LoadScene("HomeScene"); //�z�[����ʂ֖߂�
    }

    // Start is called before the first frame update
    void Start()
    {
        path = Path.Combine(Application.persistentDataPath, path);
        CoinPath = Path.Combine(Application.persistentDataPath, CoinPath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpCloBtnManager : MonoBehaviour
{

    public Button skillClose;

    private GameObject ExplanationClose;



    // Start is called before the first frame update
    void Start()
    {

        // ExplanationPanel�Ƃ����I�u�W�F�N�g��T���Ď擾
        ExplanationClose = GameObject.Find("ExplanationPanel");

        //ExplanationClose.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {

        // ���̃{�^�����\���ɂ���
        ExplanationClose.SetActive(false);



    }


}

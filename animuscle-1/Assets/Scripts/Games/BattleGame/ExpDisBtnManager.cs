using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ExpDisBtnManager : MonoBehaviour
{

    public Button skillDisplay;

    public GameObject SkillExplanation;



    // Start is called before the first frame update
    void Start()
    {
        // ExplanationPanel�Ƃ����I�u�W�F�N�g��T���Ď擾
        //SkillExplanation = GameObject.Find("ExplanationPanel");

        SkillExplanation.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {

        SkillExplanation.SetActive(true);


    }

}

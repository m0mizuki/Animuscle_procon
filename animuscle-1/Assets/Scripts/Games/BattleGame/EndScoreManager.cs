using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class EndScoreManager : MonoBehaviour
{

    public TextMeshProUGUI endCount;

    //public int endScore;



    // Start is called before the first frame update
    void Start()
    {
        // ���̃X�N���v�g�����Ă���I�u�W�F�N�g�̒���Text�Ƃ���
        // �R���|�[�l���g���擾
        //endCount = GetComponentInChildren<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        endCount.text = DestroyScoreManager.destroyScore.ToString();

    }
}

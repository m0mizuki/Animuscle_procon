using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeverFlashScript : MonoBehaviour
{

    private Text feverText;
    private float feverSpeed = 1.2f;
    private float feverTime;




    // Start is called before the first frame update
    void Start()
    {
        // ���̃I�u�W�F�N�g����Text�Ƃ����R���|�[�l���g���擾
        feverText = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        feverText.color = GetAlphaColor(feverText.color);
    }

    // �e�L�X�g��_�ŕ\��������
    Color GetAlphaColor(Color color)
    {
        feverTime += Time.deltaTime * 5.0f * feverSpeed;
        color.a = Mathf.Sin(feverTime);

        return color;
    }

}

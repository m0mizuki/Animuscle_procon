using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�J������ΏۂɒǏ]
public class RunCameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject target;
    private Vector3 CamOffset;

    // Start is called before the first frame update
    void Start()
    {
        //�J�����ƃ^�[�Q�b�g�̏����ʒu�̍��i�I�t�Z�b�g�j���擾
        CamOffset = gameObject.transform.position - target.transform.position;
    }

    void LateUpdate()
    {
        //�^�[�Q�b�g�Ƃ̃I�t�Z�b�g��ۂ��ăJ�������ړ�
        gameObject.transform.position = target.transform.position + CamOffset;
    }
}
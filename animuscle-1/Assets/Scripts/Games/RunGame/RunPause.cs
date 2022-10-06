using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�|�[�Y�{�^���ƃ|�[�Y���ɕ\������{�^�����Ǘ�
public class RunPause : MonoBehaviour
{
    private bool Paused;
    // Start is called before the first frame update
    void Start()
    {
        Paused = false;
        //�q�I�u�W�F�N�g�i�|�[�Y���ɕ\������{�^���j��������ԂŔ�\���ɐݒ�
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    public void Pushed()
    {
        //�|�[�Y���������ꍇ�A�|�[�Y���������Ďq�I�u�W�F�N�g�i�|�[�Y���ɕ\������{�^���j���\��
        if (Paused)
        {
            Paused = false;
            //�Q�[���J�n�ς݂̏ꍇ�A�Q�[�������Ԃ𓮂����i�Q�[���J�n�O�ɓ����Ă��܂����Ƃ�h���j
            if (RunStartCount.RunStarted)
            {
                Time.timeScale = 1;
            }
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(false);
            }
        }
        //�|�[�Y���łȂ������ꍇ�A�|�[�Y��L���ɂ��ăQ�[�������Ԃ��~���A�q�I�u�W�F�N�g�i�|�[�Y���ɕ\������{�^���j��\��
        else if (!Paused)
        {
            Paused = true;
            Time.timeScale = 0;
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(true);
            }
        }
    }
}

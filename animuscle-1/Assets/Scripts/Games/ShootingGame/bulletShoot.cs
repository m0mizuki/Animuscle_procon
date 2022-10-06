using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class bulletShoot : MonoBehaviour
{
    public GameObject bullet;

    public SubAudioManager sam;

    //private float interval = 2.1f-(PetStatusManager.arm / 50f);
    public static float interval;

    bool shootdown = false;


    float nowTime;
    float beforTime = 0; //�O��ɋ���ł�������

    public void ShootDown()//�{�^���������ꂽ
    {
        shootdown = true;
    }
    public void ShootUp()//�{�^���������ꂽ
    {
        shootdown = false;
    }

    private void FixedUpdate()
    {
        bulletshoot();
    }

    public void bulletshoot()//�e�̃v���n�u�����
    {
        if (!Player.damageFlag)
        {
            nowTime = Time.realtimeSinceStartup;

            if ((nowTime - beforTime > interval) && shootdown)
            {
                sam.PushTouch();
                GameObject bullets = Instantiate(bullet) as GameObject;
                bullets.transform.position = transform.position;
                beforTime = nowTime;
            }
        }

    }
}

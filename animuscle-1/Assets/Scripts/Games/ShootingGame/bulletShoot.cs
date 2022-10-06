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
    float beforTime = 0; //前回に球を打った時間

    public void ShootDown()//ボタンが押された
    {
        shootdown = true;
    }
    public void ShootUp()//ボタンが離された
    {
        shootdown = false;
    }

    private void FixedUpdate()
    {
        bulletshoot();
    }

    public void bulletshoot()//弾のプレハブを作る
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

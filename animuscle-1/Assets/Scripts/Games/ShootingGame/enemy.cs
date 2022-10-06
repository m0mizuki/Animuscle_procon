using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject PrefabEnemy;
    public GameObject PrefabEnemy2;

    public static float interval1; 
    public static float interval2;

    float nowTime;
    float beforTime1 = 0;
    float beforTime2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2.5f, 2.5f);
        Vector3 pos = new Vector3(x, 5.5f, 0);

        Instantiate(PrefabEnemy, pos, Quaternion.identity);
        
    }

    // �G�̃v���n�u�����
    void Update()
    {
        nowTime = Time.realtimeSinceStartup; 
        //�G�^�C�v1�̃v���n�u���쐬
        if (nowTime - beforTime1 > interval1)
        {
            float x = Random.Range(-2.5f, 2.5f);
            Vector3 pos = new Vector3(x, 5.5f, 0);

            Instantiate(PrefabEnemy, pos, Quaternion.identity);
            beforTime1 = nowTime;
        }
        //�G�^�C�v2�̃v���n�u���쐬
        if (nowTime - beforTime2 > interval2)
        {
            float x = Random.Range(-2.5f, 2.5f);
            Vector3 pos = new Vector3(x, 5.5f, 0);

            Instantiate(PrefabEnemy2, pos, Quaternion.identity);
            beforTime2 = nowTime;
        }
            
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public static float enemySpeed;
    private float x;
    Vector3 move;
    void Start()
    {
        x = Random.Range(-2f, 2f);
        move = new Vector3(x, -1f, 0);
    }
    // Update is called once per frame
    void Update()
    {
        //�G�𓮂���
        this.transform.Translate(move.normalized * enemySpeed * Time.deltaTime, Space.World);
        //���ɍs�����������
        if (transform.position.y <= -5)
        {
            Destroy(gameObject);
        }
        //�[�ɍs�����甽��
        if(transform.position.x < -2.5|| transform.position.x > 2.5)
        {
            move.x = -move.x;
        }
    }
}
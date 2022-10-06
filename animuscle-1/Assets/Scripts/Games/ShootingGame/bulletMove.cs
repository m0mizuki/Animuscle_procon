using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMove : MonoBehaviour
{
    public float bulletSpeed = 3;
    Vector3 move;

    GameObject audioManager;

    void Start()
    {
        move = new Vector3(0, 1f, 0);
        audioManager = GameObject.FindWithTag("AudioManager"); //����AudioManager�擾
    }
    // �e����ɓ�����
    void FixedUpdate()
    {
        this.transform.Translate(move.normalized * bulletSpeed * Time.deltaTime, Space.World);
        if (transform.position.y >= 5)
        {
            Destroy(gameObject);
        }

       
    }
    //�e�ƓG�̓����蔻��
    void OnTriggerEnter2D(Collider2D collision2D)
    {
        GameObject TouchedObject = collision2D.gameObject;

        if (TouchedObject.tag == "enemy")
        {
            audioManager.GetComponent<AudioManager>().AudioBuy();
            countscore.AddScore();
            Destroy(TouchedObject);
            Destroy(gameObject);
        }

    }

}
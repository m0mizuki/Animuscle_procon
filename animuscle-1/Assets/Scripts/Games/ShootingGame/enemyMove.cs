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
        //ìGÇìÆÇ©Ç∑
        this.transform.Translate(move.normalized * enemySpeed * Time.deltaTime, Space.World);
        //â∫Ç…çsÇ¡ÇΩÇÁè¡Ç¶ÇÈ
        if (transform.position.y <= -5)
        {
            Destroy(gameObject);
        }
        //í[Ç…çsÇ¡ÇΩÇÁîΩéÀ
        if(transform.position.x < -2.5|| transform.position.x > 2.5)
        {
            move.x = -move.x;
        }
    }
}
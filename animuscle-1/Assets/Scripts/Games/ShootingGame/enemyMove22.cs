using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove22 : MonoBehaviour
{
    public static float speed;
    Vector3 move;

    //動く向きを決める
    void Start()
    {
        move = new Vector3(Player.PlayerX - this.transform.position.x, -1f, 0f);
        move.x /= 12f;
    }

    //敵を動かす
    void Update()
    {
        this.transform.Translate(move.normalized * speed * Time.deltaTime, Space.World);
        if (transform.position.y <= -5)
        {
            Destroy(gameObject);
        }
    }
}

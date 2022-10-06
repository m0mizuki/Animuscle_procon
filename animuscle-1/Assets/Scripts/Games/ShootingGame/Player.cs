using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public static float PlayerX;
    public static float PlayerY = -3.5f;

    public SubAudioManager sam;

    bool leftPush = false;
    bool rightPush = false;
    public static float speed;
    float stay = 2.0f;
    public static bool damageFlag = false;
    Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, -2.8f, 1f);
        move = new Vector3(1f, 0, 0);
    }

    public void RightDown()
    {
        rightPush = true;
    }

    public void RightUp()
    {
        rightPush = false;
    }

    public void LeftDown()
    {
        leftPush = true;
    }

    public void LeftUp()
    {
        leftPush = false;
    }
    //プレイヤーを右に動かす
    public void PlayerRight()
    {
        this.transform.Translate(move.normalized * speed * Time.deltaTime, Space.World);
        if (transform.position.x > 2.5)
        {
            transform.position = new Vector3(2.5f, -2.8f, 1f);
        }
        PlayerX = transform.position.x;
    }
    //プレイヤーを左に動かす
    public void PlayerLeft()
    {
        this.transform.Translate(move.normalized * -speed * Time.deltaTime, Space.World);
        if (transform.position.x < -2.5)
        {
            transform.position = new Vector3(-2.5f, -2.8f, 1f);
        }
        PlayerX = transform.position.x;
    }

    void FixedUpdate()
    {
        if (!damageFlag)
        {
            if (rightPush)
            {
                PlayerRight();
            }
            if (leftPush)
            {
                PlayerLeft();
            }
        }
        
    }
    //敵とプレイヤーの当たり判定
    void OnTriggerEnter2D(Collider2D collision2D)
    {
        Debug.Log("a");
        GameObject TouchedObject = collision2D.gameObject;

        if (TouchedObject.tag == "enemy")
        {
            Destroy(TouchedObject);
            SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
            sr.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
            damageFlag = true;
            sam.PushPauseOut();
            StartCoroutine("Damage");
        }

    }
    //ダメージ中は動けない
    IEnumerator Damage()
    {
        yield return new WaitForSeconds(stay);
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        sr.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        Debug.Log("waited");
        damageFlag = false;
    }
    
}

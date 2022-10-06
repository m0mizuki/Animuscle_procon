using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//プレイヤーの動きと獲得コイン枚数を管理
public class RunPlayer : MonoBehaviour
{
    public static int RunCoin;   //獲得コイン枚数
    public float RunSpeed;  //走るスピード
    public float RunJumpP;  //ジャンプ力
    
    private bool onGround;  //接地フラグ

    public float RunDownTime;   //ダウン時間
    private bool Downed;    //ダウン中であることのフラグ

    public RunPetStatusManager PetStat; //ペットのステータス取得

    public Sprite[] PetSprite;

    public SubAudioManager sam;

    //Animator DownAnm;
    Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {
        onGround = true;
        Downed = false;
        RunCoin = 0;
        Time.timeScale = 0;

        //ペットのステータスをもとに各種ゲーム内ステータスを設定
        RunSpeed = 3.5f + (PetStat.leg * 0.5f + PetStat.arm) / 30.0f;
        RunJumpP = 30f +(PetStat.leg/10f);
        RunDownTime = 0.5f + (100.0f - PetStat.abs) / 40.0f;

        rbody = GetComponent<Rigidbody2D>();

        //ペットの見た目を設定
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = PetSprite[GameSerectManager.GamePetType];
    }

    // Update is called once per frame
    void Update()
    {
        //ダウン中でなければ移動
        if (!Downed)
        {
            rbody.velocity = new Vector2(RunSpeed, rbody.velocity.y);
        }
    }

    public void jump()
    {
        //接地中かつダウンしていなければボタンが押されたときジャンプ
        if (onGround && !Downed)
        {
            sam.PushGrow();
            rbody.AddForce(transform.up * RunJumpP, ForceMode2D.Impulse);
            //ジャンプにより地面から離れるため、接地フラグをfalseに変更
            onGround = false;
        }
    }

    //接地,ゴール判定
    void OnCollisionEnter2D(Collision2D collision)
    {
        //地面に接地したとき接地フラグをtrueに変更
        if (collision.gameObject.tag=="Ground")
        {
            onGround = true;
            Debug.Log("onGround");
        }
        //ゴールに触れたときゲーム内時間を止めリザルト画面へ移行
        else if (collision.gameObject.tag == "Goal")
        {
            sam.PushUnlock();
            Time.timeScale = 0;
            SceneManager.LoadScene("RunResult");
        }
        
    }
    //ダウンしたときの処理
    private IEnumerator Down()
    {
        /*
        ダウンフラグをtrueにし、プレイヤーを後ろにノックバック
        （より自然になるよう、空中と接地中でノックバック方向を変えた）
        */

        Downed = true;
        if(onGround)
            rbody.AddForce(new Vector2(-20f, 10f), ForceMode2D.Impulse);
        else
            rbody.AddForce(new Vector2(-20f, 0f), ForceMode2D.Impulse);
        //ダウン時間分待機してダウンフラグをfalseに戻す
        yield return new WaitForSeconds(RunDownTime);
        Downed = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //コインに接触時、コインを削除してカウントを増加
        if (collision.gameObject.tag == "Coin")
        {
            //collision.gameObject.SetActive(false);
            sam.PushSell();
            Destroy(collision.gameObject);
            RunCoin++;
        }
        //お邪魔に接触時、お邪魔を削除してダウン処理へ
        else if (collision.gameObject.tag == "Obstacle")
        {
            //collision.gameObject.SetActive(false);
            sam.PushPauseOut();
            Destroy(collision.gameObject);
            StartCoroutine("Down");
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//�v���C���[�̓����Ɗl���R�C���������Ǘ�
public class RunPlayer : MonoBehaviour
{
    public static int RunCoin;   //�l���R�C������
    public float RunSpeed;  //����X�s�[�h
    public float RunJumpP;  //�W�����v��
    
    private bool onGround;  //�ڒn�t���O

    public float RunDownTime;   //�_�E������
    private bool Downed;    //�_�E�����ł��邱�Ƃ̃t���O

    public RunPetStatusManager PetStat; //�y�b�g�̃X�e�[�^�X�擾

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

        //�y�b�g�̃X�e�[�^�X�����ƂɊe��Q�[�����X�e�[�^�X��ݒ�
        RunSpeed = 3.5f + (PetStat.leg * 0.5f + PetStat.arm) / 30.0f;
        RunJumpP = 30f +(PetStat.leg/10f);
        RunDownTime = 0.5f + (100.0f - PetStat.abs) / 40.0f;

        rbody = GetComponent<Rigidbody2D>();

        //�y�b�g�̌����ڂ�ݒ�
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = PetSprite[GameSerectManager.GamePetType];
    }

    // Update is called once per frame
    void Update()
    {
        //�_�E�����łȂ���Έړ�
        if (!Downed)
        {
            rbody.velocity = new Vector2(RunSpeed, rbody.velocity.y);
        }
    }

    public void jump()
    {
        //�ڒn�����_�E�����Ă��Ȃ���΃{�^���������ꂽ�Ƃ��W�����v
        if (onGround && !Downed)
        {
            sam.PushGrow();
            rbody.AddForce(transform.up * RunJumpP, ForceMode2D.Impulse);
            //�W�����v�ɂ��n�ʂ��痣��邽�߁A�ڒn�t���O��false�ɕύX
            onGround = false;
        }
    }

    //�ڒn,�S�[������
    void OnCollisionEnter2D(Collision2D collision)
    {
        //�n�ʂɐڒn�����Ƃ��ڒn�t���O��true�ɕύX
        if (collision.gameObject.tag=="Ground")
        {
            onGround = true;
            Debug.Log("onGround");
        }
        //�S�[���ɐG�ꂽ�Ƃ��Q�[�������Ԃ��~�߃��U���g��ʂֈڍs
        else if (collision.gameObject.tag == "Goal")
        {
            sam.PushUnlock();
            Time.timeScale = 0;
            SceneManager.LoadScene("RunResult");
        }
        
    }
    //�_�E�������Ƃ��̏���
    private IEnumerator Down()
    {
        /*
        �_�E���t���O��true�ɂ��A�v���C���[�����Ƀm�b�N�o�b�N
        �i��莩�R�ɂȂ�悤�A�󒆂Ɛڒn���Ńm�b�N�o�b�N������ς����j
        */

        Downed = true;
        if(onGround)
            rbody.AddForce(new Vector2(-20f, 10f), ForceMode2D.Impulse);
        else
            rbody.AddForce(new Vector2(-20f, 0f), ForceMode2D.Impulse);
        //�_�E�����ԕ��ҋ@���ă_�E���t���O��false�ɖ߂�
        yield return new WaitForSeconds(RunDownTime);
        Downed = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //�R�C���ɐڐG���A�R�C�����폜���ăJ�E���g�𑝉�
        if (collision.gameObject.tag == "Coin")
        {
            //collision.gameObject.SetActive(false);
            sam.PushSell();
            Destroy(collision.gameObject);
            RunCoin++;
        }
        //���ז��ɐڐG���A���ז����폜���ă_�E��������
        else if (collision.gameObject.tag == "Obstacle")
        {
            //collision.gameObject.SetActive(false);
            sam.PushPauseOut();
            Destroy(collision.gameObject);
            StartCoroutine("Down");
        }
    }
}
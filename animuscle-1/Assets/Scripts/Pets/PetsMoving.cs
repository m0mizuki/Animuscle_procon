using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetsMoving : MonoBehaviour
{
    public SubAudioManager sam;

    public int Cycle; //�ҋ@���Ԃ����������[�V�����̃t���[����
    public int CycleAll; //���[�V����1���̃t���[����

    public Vector3 PetMainPos = new Vector3(0, 0, 0); //�y�b�g�̈ʒu
    float PosZ = 0; //z���W

    GameObject clickedGameObject; //�N���b�N���ꂽ�I�u�W�F�N�g
    bool jump = false; //�W�����v���[�V������
    int jumpZ; //z���W�̕ω���
    int motionC = 0; //�ړ��̃��[�V�����J�E���g
    Vector3 fromPos = new Vector3(0, 0, 0);
    Vector3 toPos = new Vector3(0, 0, 0);

    public Sprite[] PetSprite;

    int type = 0; //�y�b�g�̃^�C�v

    int onApple;

    // Start is called before the first frame update
    void Start()
    {
        PetMainPos = this.transform.position;

        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = PetSprite[type];

        onApple = 0;
    }

    public void Create(int num)
    {
        type = num;
    }

    // Update is called once per frame
    void Update()
    {
        //���g�������ꂽ�Ƃ��W�����v�̓����Ɉڍs����
        if (Input.GetMouseButtonDown(0))
        {
            clickedGameObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if (hit2d) clickedGameObject = hit2d.transform.gameObject;
            //Debug.Log(clickedGameObject);

            if (clickedGameObject == this.gameObject && !jump)
            {
                jump = true;
                jumpZ = 50;
                sam.PushGrow();
            }
        }
    }

    void FixedUpdate()
    {
        this.transform.localScale = new Vector3(1, 1, 1);
        
        //�W�����v���Ȃ�
        if (jump)
        {
            PosZ += jumpZ * 0.0016f;
            //transform.position = new Vector3(PetMainPos.x, PetMainPos.y + PosZ, PetMainPos.z);
            this.transform.localScale = new Vector3(1 - jumpZ * 0.003f, 1 + jumpZ * 0.003f, 1);
            if (jumpZ <= -50)
            {
                jump = false;
                motionC = Cycle;
            }
            jumpZ -= 2;
        }
        else
        {
            if (motionC >= CycleAll) motionC = 0;
            motionC+=5;

            //�����̃T�C�N���̈�Ԃ͂��߂̂Ƃ�
            if (motionC == 5)
            {

                //�y�b�g���ʕ��܂ł��ǂ蒅�����Ƃ����ł�����
                if (onApple == 1 && type + 1 == ItemUsing.FruitType)
                {
                    ItemUsing.FruitType = 0;
                    ItemUsing.applePos = new Vector3(99, 99, 99);
                    sam.PushBuy();
                }

                fromPos = PetMainPos;
                if (ItemUsing.applePos != new Vector3(99, 99, 99) && type + 1 == ItemUsing.FruitType)
                {
                    onApple = 1; //�y�b�g���ʕ��܂ł��ǂ蒅������
                    if (Mathf.Abs(ItemUsing.applePos.x - toPos.x) > 0.5f)
                    {
                        toPos.x += Mathf.Sign(ItemUsing.applePos.x - toPos.x) * 0.5f;
                        onApple = 0;
                    }
                    else toPos.x = ItemUsing.applePos.x;
                    if (Mathf.Abs(ItemUsing.applePos.y - toPos.y) > 0.5f)
                    {
                        toPos.y += Mathf.Sign(ItemUsing.applePos.y - toPos.y) * 0.5f;
                        onApple = 0;
                    }
                    else toPos.y = ItemUsing.applePos.y;

                }
                else
                {
                    //�ړ����ݒ�
                    if (toPos.x > 1.2f) toPos.x = Random.Range(fromPos.x - 0.5f, fromPos.x);
                    else if (toPos.x < -1.2f) toPos.x = Random.Range(fromPos.x, fromPos.x + 0.5f);
                    else toPos.x = Random.Range(fromPos.x - 0.5f, fromPos.x + 0.5f);
                    if (toPos.y > 1.5f) toPos.y = Random.Range(fromPos.y - 0.5f, fromPos.y);
                    else if (toPos.y < -1.5f) toPos.y = Random.Range(fromPos.y, fromPos.y + 0.5f);
                    else toPos.y = Random.Range(fromPos.y - 0.5f, fromPos.y + 0.5f);
                }

            }

            //�����̃T�C�N�����Ȃ�ʒu��ς���
            if (motionC <= Cycle)
            {
                PetMainPos.x = fromPos.x + (toPos.x - fromPos.x) * motionC / Cycle;
                PetMainPos.y = fromPos.y + (toPos.y - fromPos.y) * motionC / Cycle;
                //transform.position = new Vector3(PetMainPos.x, PetMainPos.y + PosZ, PetMainPos.z);
                this.transform.localScale = new Vector3(1 + (Cycle * 0.5f - Mathf.Abs(motionC - Cycle * 0.5f)) * 0.001f, 1 - (Cycle * 0.5f - Mathf.Abs(motionC - Cycle * 0.5f)) * 0.001f, 1);
            }
        }

        //�ʒu�Ƒ傫����ݒ�
        transform.position = new Vector3(PetMainPos.x, PetMainPos.y + PosZ, PetMainPos.z);
    }
}
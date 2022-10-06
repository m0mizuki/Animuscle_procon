using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleMoving : MonoBehaviour
{
    Vector3 ApplePos; //このスクリプト内のみ
    float PosZ = 1.0f; //z座標
    int VZ = 0; //zの速度

    int type = 1; //果物の種類

    //イメージ
    public Sprite fruit1;
    public Sprite fruit2;
    public Sprite fruit3;

    // Start is called before the first frame update
    void Start()
    {
        ApplePos = this.transform.position;

        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        if (type == 1) sr.sprite = fruit1;
        if (type == 2) sr.sprite = fruit2;
        if (type == 3) sr.sprite = fruit3;
    }

    public void Create(int num)
    {
        type = num;
    }

    // Update is called once per frame
    void Update()
    {
        //果物の動きと消滅の処理
        if (PosZ != 0)
        {
            PosZ -= VZ * 0.001f;
            VZ++;
            if (PosZ < 0) PosZ = 0f;
        }
        transform.position = new Vector3(ApplePos.x, ApplePos.y + PosZ, 2);
        if (ItemUsing.applePos == new Vector3(99, 99, 99)) Destroy(this.gameObject);
    }
}

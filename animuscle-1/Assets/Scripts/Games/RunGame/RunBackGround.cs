using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunBackGround : MonoBehaviour
{
    private float cameraRect;
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        //オブジェクト初期位置取得
        pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //カメラ表示範囲取得
        cameraRect = Camera.main.WorldToViewportPoint(pos).x;
        //カメラ外に出たら移動
        if (cameraRect < -1.7)
        {
            pos.x += 18;
            transform.position = pos;
            pos = this.transform.position;
        }
    }
}

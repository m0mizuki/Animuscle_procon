using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//カメラを対象に追従
public class RunCameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject target;
    private Vector3 CamOffset;

    // Start is called before the first frame update
    void Start()
    {
        //カメラとターゲットの初期位置の差（オフセット）を取得
        CamOffset = gameObject.transform.position - target.transform.position;
    }

    void LateUpdate()
    {
        //ターゲットとのオフセットを保ってカメラを移動
        gameObject.transform.position = target.transform.position + CamOffset;
    }
}
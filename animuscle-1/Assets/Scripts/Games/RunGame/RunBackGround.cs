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
        //�I�u�W�F�N�g�����ʒu�擾
        pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //�J�����\���͈͎擾
        cameraRect = Camera.main.WorldToViewportPoint(pos).x;
        //�J�����O�ɏo����ړ�
        if (cameraRect < -1.7)
        {
            pos.x += 18;
            transform.position = pos;
            pos = this.transform.position;
        }
    }
}

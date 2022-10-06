using UnityEngine;
using System.IO;
using System.Collections;
using NatSuite.Sharing;
using UnityEngine.UI;

public class ShareController : MonoBehaviour
{
    public static bool CanCanmera = false;

    public GameObject CameraButton;

    public GameObject Buttons;

    void Start()
    {
        if (CanCanmera) CameraButton.SetActive(true);
        else CameraButton.SetActive(false);
    }

    
    public void Share()
    {
        StartCoroutine(ShareC());
    }
    
    public IEnumerator ShareC()
    {
        CanCanmera = false;
        CameraButton.SetActive(false);
        Buttons.SetActive(false);
        yield return null; //1�t���[���҂�

        //�X�N���[���V���b�g���쐬
        var screenshot = ScreenCapture.CaptureScreenshotAsTexture();
        var payload = new SharePayload();
        //�X�N�V���̉摜��ǉ�
        payload.AddText("���̃y�b�g�I");
        payload.AddImage(screenshot);

        payload.Commit();

        Buttons.SetActive(true);
    }

}
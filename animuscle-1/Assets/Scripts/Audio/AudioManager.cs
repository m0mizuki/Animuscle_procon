using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip Button;
    public AudioClip Sell;
    public AudioClip Grow;
    public AudioClip Touch;
    public AudioClip PauseOut;
    public AudioClip PauseIn;
    public AudioClip Buy;
    public AudioClip Clear;
    public AudioClip Fail;
    public AudioClip Unlock;

    public AudioSource audioSource;

    public float VolumeBGM;
    public float VolumeSE;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        audioSource.Play(); //BGM

        VolumeBGM = 1.0f;
        VolumeSE = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AudioButton()
    {
        audioSource.PlayOneShot(Button, VolumeSE);
    }

    public void AudioSell()
    {
        audioSource.PlayOneShot(Sell, VolumeSE);
    }

    public void AudioGrow()
    {
        audioSource.PlayOneShot(Grow, VolumeSE);
    }

    public void AudioTouch()
    {
        audioSource.PlayOneShot(Touch, VolumeSE);
    }

    public void AudioPauseOut()
    {
        audioSource.PlayOneShot(PauseOut, VolumeSE);
    }

    public void AudioPauseIn()
    {
        audioSource.PlayOneShot(PauseIn, VolumeSE);
    }

    public void AudioBuy()
    {
        audioSource.PlayOneShot(Buy, VolumeSE);
    }

    public void AudioClear()
    {
        audioSource.PlayOneShot(Clear, VolumeSE);
    }
    public void AudioFail()
    {
        audioSource.PlayOneShot(Fail, VolumeSE);
    }

    public void AudioUnlock()
    {
        audioSource.PlayOneShot(Unlock, VolumeSE);
    }


    public void SetBGMvolume()
    {
        audioSource.volume = VolumeBGM;
    }
}

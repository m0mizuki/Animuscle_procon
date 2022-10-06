using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubAudioManager : MonoBehaviour
{
    GameObject audioManager;

    // Start is called before the first frame update
    void Start()
    {
        audioManager = GameObject.FindWithTag("AudioManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushButton()
    {
        audioManager.GetComponent<AudioManager>().AudioButton();
    }

    public void PushSell()
    {
        audioManager.GetComponent<AudioManager>().AudioSell();
    }

    public void PushGrow()
    {
        audioManager.GetComponent<AudioManager>().AudioGrow();
    }

    public void PushTouch()
    {
        audioManager.GetComponent<AudioManager>().AudioTouch();
    }

    public void PushPauseOut()
    {
        audioManager.GetComponent<AudioManager>().AudioPauseOut();
    }

    public void PushPauseIn()
    {
        audioManager.GetComponent<AudioManager>().AudioPauseIn();
    }

    public void PushBuy()
    {
        audioManager.GetComponent<AudioManager>().AudioBuy();
    }

    public void PushClear()
    {
        audioManager.GetComponent<AudioManager>().AudioClear();
    }

    public void PushFail()
    {
        audioManager.GetComponent<AudioManager>().AudioFail();
    }

    public void PushUnlock()
    {
        audioManager.GetComponent<AudioManager>().AudioUnlock();
    }
}

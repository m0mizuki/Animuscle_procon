using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class timeCount : MonoBehaviour
{
    int time = 30;
    public TextMeshProUGUI timeText;
    //[SerializeField]
    //private float interval = 1.0f;
    [SerializeField]
    private float tmpTime;

    int DispTime;

    void start()
    {
        tmpTime = 0;
    }

    //時間をカウントダウン
    void Update()
    {
        tmpTime += Time.deltaTime;
        DispTime = time - (int)tmpTime;
        timeText.text = "TIME: " + DispTime.ToString();
        
        if (DispTime <= 0)
        {
            SceneManager.LoadScene("ShootingResult");
        }
    }

}
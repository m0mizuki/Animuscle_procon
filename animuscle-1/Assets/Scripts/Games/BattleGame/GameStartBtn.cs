using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartBtn : MonoBehaviour
{

    public void OnClickStartButton()
    {
        // ボタンが押されたらシーンを切り替える
        SceneManager.LoadScene("BattleMain");
    }





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

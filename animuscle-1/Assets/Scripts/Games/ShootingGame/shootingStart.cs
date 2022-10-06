using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shootingStart : MonoBehaviour
{
    public void returndown()
    {
        SceneManager.LoadScene("GameSelectScene");
    }
    public void Startdown()
    {
        SceneManager.LoadScene("ShootingMain");
    }
}

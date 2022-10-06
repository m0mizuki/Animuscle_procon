using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;


    [SerializeField]
    private Slider HPSlider;
    [SerializeField]
    private PlayerController player;


    [SerializeField]
    private Slider EnemyHP;
    [SerializeField]
    private EnemyController enemy;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void UpdateHealthUI()
    {
        HPSlider.maxValue = player.maxHealth;
        HPSlider.value = player.currentHealth;



    }


    public void UpdateEnemyHealthUI()
    {
        EnemyHP.maxValue = enemy.maxHealth;
        EnemyHP.value = enemy.currentHealth;
    }


}

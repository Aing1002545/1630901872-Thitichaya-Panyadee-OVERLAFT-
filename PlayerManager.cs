using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;


public class PlayerManager : MonoBehaviour
{
    public static int currentHealth = 100;
    public Slider healthBar;

    public static bool gameOver;
    public GameObject gameOverPanel;

    void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        //Update the slider value
        healthBar.value = currentHealth;

        //game over
        if(currentHealth < 0)
        {
            gameOver = true;
            gameOverPanel.SetActive(true);
            currentHealth = 100;
            
        }

    }
}

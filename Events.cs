using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Events : MonoBehaviour
{
    //replay level
    public void ReplayLevel()
    {
        SceneManager.LoadScene("menu");
    }

   public void QuitGame()
    {
        Debug.Log ("QUIT!");
        Application.Quit();
    }
}


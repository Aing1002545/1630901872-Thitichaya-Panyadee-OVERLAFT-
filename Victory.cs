using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
        
   public void ChangeScene()
   {
    SceneManager.LoadScene("menu");
   }

    
    public void QuitGame()
    {
        Debug.Log ("QUIT!");
        Application.Quit();
    }
}

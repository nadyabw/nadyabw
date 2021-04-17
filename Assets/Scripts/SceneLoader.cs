using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneLoader
{
    #region Public metods
    
    public static void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    public static void ChangeScene(int sceneInsex)
    {
        SceneManager.LoadScene(sceneInsex);
    }

    public static void ExitGame()
    {
        Application.Quit();
    }
    
    #endregion

}

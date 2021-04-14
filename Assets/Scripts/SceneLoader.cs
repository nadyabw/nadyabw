using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    #region Public metods
    
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    public void ChangeScene(int sceneInsex)
    {
        SceneManager.LoadScene(sceneInsex);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    
    #endregion

}

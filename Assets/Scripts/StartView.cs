using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartView : MonoBehaviour
{
    #region Varibel
    
    public Button startButton; //Кнопка Начать заново
    public Button exitButton;  //Кнопка Выход
    
    #endregion
    
    #region Unity Lifecycle
    void Start()
    {
        startButton.onClick.AddListener(startClickHandler); //Нажатие кнопки Старт
        exitButton.onClick.AddListener(exitClickHandler);  //Нажатие кнопки Выход
    }
    #endregion
    
    #region Private Methods
    private void startClickHandler() // Нажать кнопку Начать заново
    {
      SceneLoader.ChangeScene(1); //Переход в Сцену игры
    }

    private void exitClickHandler()  // Нажать кнопку Выход
    {
      SceneLoader.ExitGame(); // Выход
    }
    #endregion
}

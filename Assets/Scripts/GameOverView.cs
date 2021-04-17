using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class GameOverView : MonoBehaviour
{

    #region Varibel

    public Text attempLabel;
    public Text rasultLabel;
    public Button playButton;
    public Button exitButton;
    
    #endregion

    #region Unity Lifecycle
    private void Start()
    {
        attempLabel.text =$"Результат = {Result.correctNumber}";  // Вывод угаданного числа 
        rasultLabel.text =$"Количество шагов = {Result.attemptsNumber}";  // Вывод количества шагов
        playButton.onClick.AddListener(playClickHandler);  //Нажатие кнопки Начать заново
        exitButton.onClick.AddListener(exitClickHandler);  //Нажатие кнопка Выход 
    }
    #endregion
    
    #region Private Methods
    private void playClickHandler() //Кнопка Начать заново
    {
        SceneLoader.ChangeScene(0); //Переход в начальную сцену
    }

    private void exitClickHandler() //Кнопка Выход 
    {
        SceneLoader.ExitGame(); //Выход
    }
   #endregion
}

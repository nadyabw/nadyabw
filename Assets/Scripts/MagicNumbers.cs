using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MagicNumbers : MonoBehaviour
{
    #region Varibel
   
    public int i;
    public int currentnumber = 500;
    private int minNumber;
    private int maxNumber = 1000;
    public Text startText;
    public Text resultext;
    public Button greaterButton;
    public Button lessButton;
    public Button equalButton;
    
    #endregion
    
    #region Unity Lifecycle
    void Start()
    {
        greaterButton.onClick.AddListener(greaterClickHandler); //Кнопка Выше
        lessButton.onClick.AddListener(lessClickHandler); //Кнопка Ниже
        equalButton.onClick.AddListener(equalClickHandler); // Кнопка Равно
        
        startText.text = $"Загадай число от 1 до 1000. ";
        resultext.text = $"Ты загадал 500? ";
    }
   void Update()
    {
        
    }
    
    public void greaterClickHandler() //Если Выше
    {
            minNumber = currentnumber;
            currentnumber = (maxNumber + minNumber) / 2;
            startText.text = $"Ты загадал {currentnumber} ? ";
            resultext.text = $"";
            i++;

    }

    public void lessClickHandler() //Если Ниже
    {
            maxNumber = currentnumber;
            currentnumber = (maxNumber + minNumber) / 2;
            startText.text = $"Ты загадал {currentnumber} ? ";
            resultext.text = $"";
            i++;
    }
    public void equalClickHandler() //Если Равно
    {
           
            startText.text = $"Ты загадал {currentnumber} ! ";
            resultext.text = $"Число шагов {i}. ";
            SceneLoader.ChangeScene(2);
            Result.setResult(currentnumber, i);
    }
    #endregion
}

    #region Events 

   public static class Result  //Создание статических переменных с текущими результатами
     {
      public static int correctNumber;
      public static int attemptsNumber;
    
      public static void setResult(int correctNum, int attempsNum)
       {
        correctNumber = correctNum;
        attemptsNumber = attempsNum;
       }
     }
  #endregion
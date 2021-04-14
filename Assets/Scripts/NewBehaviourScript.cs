using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    #region Varibels

    public int result, turnsNumber, gameOverValue = 50;
    public Text text;
    public Text textStop;
    public Text textStart;
    public SceneLoader SceneLoader;

    private bool isPlay = true;

    #endregion

     void Awake()
    {
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        StartGame();
    }

    #region Unity Lifecycle

    void Update()
    {
        if (!isPlay)
        {
            return;
        }
        CheckPressedKeys();
    }
 
    private void StartGame() 
    {
        result = 0;
        turnsNumber = 0;
        ShowTurnMessage();
        print("Введите число от 0 до 9.");
        textStart.text = $"Введите число от 0 до 9.";
    }

    private void ShowTurnMessage() 
    {
        print("Результат - " + result + ".");
        text.text = $"Результат - {result}";
        print("Введите число от 0 до 9.");
        textStart.text = $"Введите число от 0 до 9.";
    }

    private void ShowGameOverMessage() 
    {
        
        print("Игра окончена. Результат - " + result + "Количество шагов = " + turnsNumber + ".");
        textStop.text = $"Игра окончена. Результат -  {result} Количество шагов = {turnsNumber}";
      
    }

    private void CheckPressedKeys()
    {
        int keyValue = 0;

        if (Input.GetKeyDown (KeyCode.Keypad1) || Input.GetKeyDown (KeyCode.Alpha1))
        {
            keyValue = 1;
        }
        
        else if (Input.GetKeyDown (KeyCode.Keypad2) || Input.GetKeyDown (KeyCode.Alpha2))
        {
            keyValue = 2;
        }
        else if (Input.GetKeyDown (KeyCode.Keypad3) || Input.GetKeyDown (KeyCode.Alpha3))
        {
            keyValue = 3;
        }
        else if (Input.GetKeyDown (KeyCode.Keypad4) || Input.GetKeyDown (KeyCode.Alpha4))
        {
            keyValue = 4;
        }
        else if (Input.GetKeyDown (KeyCode.Keypad5) || Input.GetKeyDown (KeyCode.Alpha5))
        {
            keyValue = 5;
        }
        else if (Input.GetKeyDown (KeyCode.Keypad6) || Input.GetKeyDown (KeyCode.Alpha6))
        {
            keyValue = 6;
        }
        else if (Input.GetKeyDown (KeyCode.Keypad7) || Input.GetKeyDown (KeyCode.Alpha7))
        {
            keyValue = 7;
        }
        else if (Input.GetKeyDown (KeyCode.Keypad8) || Input.GetKeyDown (KeyCode.Alpha8))
        {
            keyValue = 8;
        }
        else if (Input.GetKeyDown (KeyCode.Keypad9) || Input.GetKeyDown (KeyCode.Alpha9))
        {
            keyValue = 9;
        }
        else if (Input.GetKeyDown (KeyCode.Space))
        {
            StartGame();
        }

        if (keyValue > 0)
        {
            result += keyValue;
            turnsNumber++;
            CheckGameState();
        }
    }

    private void CheckGameState()
    {
        if (result >= gameOverValue)
        {
            SceneLoader.ChangeScene(2);
            ShowGameOverMessage();
            StartGame();
        }
        else
        {
            ShowTurnMessage();
        }
    }

    #endregion
}

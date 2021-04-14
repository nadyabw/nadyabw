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

    public NewBehaviourScript mugicNumbers; 

    #endregion

    #region Unity Lifecycle
    private void Start()
    {
        NewBehaviourScript magicNumbers = FindObjectOfType<NewBehaviourScript>();
        attempLabel.text =$"Результат = {magicNumbers.result}";
        rasultLabel.text =$"Количество шагов = {magicNumbers.turnsNumber}";
    }
    #endregion
}

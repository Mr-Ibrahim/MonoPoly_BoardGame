using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice_Script : MonoBehaviour
{
    public static Dice_Script _instance;
    private void Awake()
    {
        _instance = this;
    }

    private const int maxDiceValue=6;
    public int randomNum;
    public void DiceNumber()
    {
        DiceRandomNumber();
        
    }
    public int DiceRandomNumber()
    {
        randomNum = Random.Range(1, maxDiceValue + 1);
        print(randomNum);
        return randomNum;
    }


}

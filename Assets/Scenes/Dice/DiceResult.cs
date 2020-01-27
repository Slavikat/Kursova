using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceResult : MonoBehaviour
{
    public Button buttonDice;
    public Button buttonStep;
    public bool start = false;
    public static float timeLeft2 = 3.0f;
    public void Update()
    {
        if (start)
        {
           
            timeLeft2 -= Time.deltaTime;
                if (timeLeft2 <= 0)
                {
                start = false;
                buttonStep.interactable = true;
            }
            

        }
        //     if (PlayerData.dice)
        //     {
        //        button.interactable = true;
        //    }
        //    else
        //    {
        //       button.interactable = false;
        //    }
    }
    public void Result()
    {
        DiceScript.roll = true;
        DiceScript2.roll = true;
        buttonDice.interactable = false;
        start = true;
        timeLeft2 = 3.0f;
    }
    }

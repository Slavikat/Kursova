using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{

    public Button buttonStep;
    public void Update()
    {
    //    if (PlayerData.go)
    //    {
     //       button.interactable = true;
     //   }
     //   else
     //   {
    //        button.interactable = false;
    //    }
    }
    void Start()
    {
        
    }

    public void Click()
    {
        buttonStep.interactable = false;
switch (Moved.player)
            {
                case 1:
                AddKlit(1);
                PlayerData.play = 0;
                    Moved.player = 2;
                    Moved.plG = true;
                  
                    break;
                case 2:
                AddKlit(2);
                PlayerData.play = 1;
                if (PlayerData.sumPlayer >= 3)
                {
                   Moved.player = 3;
                }
                else Moved.player = 1;
                Moved.plR = true;
                    break;
                case 3:
                AddKlit(3);
                PlayerData.play =2;
                if (PlayerData.sumPlayer == 4)
                {
                    Moved.player = 4;
                }
                else Moved.player = 1;
                
                    Moved.plY = true;
                    
                    break;
                case 4:
                AddKlit(4);
                PlayerData.play = 3;
                Moved.player = 1;
                    Moved.plB = true;
                    
                    break;
            }
    }
    public void AddKlit(int k)
    {
        PlayerData.Klitynka[k-1] += DiceNumberTextScript.diceNumber;
        if (PlayerData.Klitynka[k-1] > 40) { PlayerData.Klitynka[k] -= 40; }
    }
    // Update is called once per frame
   
}

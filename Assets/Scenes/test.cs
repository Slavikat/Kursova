using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Click()
    {
switch(Moved.player)
            {
                case 1:
              //  AddKlit(1);
            //    PlayerData.play = Moved.player;
                    Moved.player = 2;
                    Moved.plG = true;
                  
                    break;
                case 2:
            //    AddKlit(2);
           //     PlayerData.play = Moved.player;
                if (PlayerData.sumPlayer >= 3)
                {
                   Moved.player = 3;
                }
                else Moved.player = 1;
                Moved.plR = true;
                    break;
                case 3:
             //   AddKlit(3);
            //    PlayerData.play = Moved.player;
                if (PlayerData.sumPlayer == 4)
                {
                    Moved.player = 4;
                }
                else Moved.player = 1;
                
                    Moved.plY = true;
                    
                    break;
                case 4:
            //    AddKlit(4);
             //   PlayerData.play = Moved.player;
                Moved.player = 1;
                    Moved.plB = true;
                    
                    break;
            }
    }
    public void AddKlit(int k)
    {
        PlayerData.Klitynka[k] += DiceNumberTextScript.diceNumber;
        if (PlayerData.Klitynka[k] > 40) PlayerData.Klitynka[k] -= 40;
    }
    // Update is called once per frame
    void Update()
    {
        
            
           

        
     
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMainScene : MonoBehaviour
{

    public Text name1;
    public Text name2;
    public Text name3;
    public Text name4;
    public Text score1;
    public Text score2;
    public Text score3;
    public Text score4;
    static int i = 2;
    public Button buttonDice;
    public Button buttonStep;



    // Start is called before the first frame update
    void Start()
    {
        setPlayerInfo();
        buttonDice.interactable = true;
        buttonStep.interactable = false;
    }

    public void setPlayerInfo()
    {
        i = PlayerData.sumPlayer;
        name1.text = PlayerData.Name[0];
        name2.text = PlayerData.Name[1];
        if (PlayerData.sumPlayer >= 3)
        {
         
            name3.text = PlayerData.Name[2];
            if (PlayerData.sumPlayer == 4)
            {
                name4.text = PlayerData.Name[3];
        
            }
        }
       
        PlayerData.Score = new int[i];
        PlayerData.Klitynka = new int[i];
        PlayerData.Pola = new string[40];

        PlayerData.Score[0] = 20;
        PlayerData.Score[1] = 20;

        if (i >= 3)
        {
            PlayerData.Score[2] = 20;
            if (i == 4)
            {
                PlayerData.Score[3] = 20;
            }
        }

    

        PlayerData.Klitynka[0] = 1;
        PlayerData.Klitynka[1] = 1;

        if (i >= 3)
        {
            PlayerData.Klitynka[2] = 1;
            if (i == 4)
            {
                PlayerData.Klitynka[3] = 1;
            }
        }
        
       
           
         
        PlayerData.Pola[0] = "st";
        PlayerData.Pola[1] = "1";
        PlayerData.Pola[2] = "+5";
        PlayerData.Pola[3] = "5";
        PlayerData.Pola[4] = "1";
        PlayerData.Pola[5] = "1";
        PlayerData.Pola[6] = "p";
        PlayerData.Pola[7] = "-5";
        PlayerData.Pola[8] = "5";
        PlayerData.Pola[9] = "v";
        PlayerData.Pola[10] = "+15";

        PlayerData.Pola[11] = "p";
        PlayerData.Pola[12] = "2";
        PlayerData.Pola[13] = "-5";
        PlayerData.Pola[14] = "2";
        PlayerData.Pola[15] = "5";
        PlayerData.Pola[16] = "v";
        PlayerData.Pola[17] = "5";
        PlayerData.Pola[18] = "2";
        PlayerData.Pola[19] = "p";
        PlayerData.Pola[20] = "p";

        PlayerData.Pola[21] = "3";
        PlayerData.Pola[22] = "5";
        PlayerData.Pola[23] = "+5";
        PlayerData.Pola[24] = "3";
        PlayerData.Pola[25] = "p";
        PlayerData.Pola[26] = "5";
        PlayerData.Pola[27] = "3";
        PlayerData.Pola[28] = "p";
        PlayerData.Pola[29] = "v";
        PlayerData.Pola[30] = "-15";

        PlayerData.Pola[31] = "5";
        PlayerData.Pola[32] = "+5";
        PlayerData.Pola[33] = "4";
        PlayerData.Pola[34] = "4";
        PlayerData.Pola[35] = "v";
        PlayerData.Pola[36] = "p";
        PlayerData.Pola[37] = "5";
        PlayerData.Pola[38] = "p";
        PlayerData.Pola[39] = "-5";


    }

    // Update is called once per frame
    void Update()
    {
        score1.text = PlayerData.Score[0].ToString();
  
        score2.text = PlayerData.Score[1].ToString();
     
        if (i >= 3)
        {
         score3.text = PlayerData.Score[2].ToString(); 
         
            if (i == 4)
            {
              score4.text = PlayerData.Score[3].ToString();
           
            }
        }

       
 
    }

    
}

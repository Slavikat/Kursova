using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resultat : MonoBehaviour
{
    public Text name1;
    public Text name2;
    public Text name3;
    public Text name4;
    public Text score1;
    public Text score2;
    public Text score3;
    public Text score4;
    public int i =2;
    // Start is called before the first frame update
    void Start()
    {
        setPlayerInfo();
    }
    public void setPlayerInfo()
    {
        int temp;
        string temp2;
        for (int i = 0; i < PlayerData.Score.Length; i++)
            for (int j = i + 1; j < PlayerData.Score.Length; j++)
                if (PlayerData.Score[i] < PlayerData.Score[j])
                {
                    temp2 = PlayerData.Name[j];
                    temp = PlayerData.Score[j];
                    PlayerData.Name[j] = PlayerData.Name[i];
                    PlayerData.Score[j] = PlayerData.Score[i];
                    PlayerData.Name[i] = temp2;
                    PlayerData.Score[i] = temp;
                }


      

        i = PlayerData.sumPlayer;
        name1.text = PlayerData.Name[0];
        name2.text = PlayerData.Name[1];
        if (PlayerData.sumPlayer >= 3)
        {
            //   i = 3;
            name3.text = PlayerData.Name[2];
            if (PlayerData.sumPlayer == 4)
            {
                name4.text = PlayerData.Name[3];
                //        i = 4;
            }
        }
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
        void Update()
    {
        
    }
}

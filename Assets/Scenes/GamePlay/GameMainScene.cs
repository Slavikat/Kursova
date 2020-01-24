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


    // Start is called before the first frame update
    void Start()
    {
        setPlayerInfo();
    }

    public void setPlayerInfo()
    {
        name1.text = PlayerData.Name[0];
        name2.text = PlayerData.Name[1];
        if (PlayerData.sumPlayer >= 3)
        {
            i = 3;
            name3.text = PlayerData.Name[2];
            if (PlayerData.sumPlayer == 4)
            {
                name4.text = PlayerData.Name[3];
                i = 4;
            }
        }
        score1.text = "20";
        score2.text = "20";

        if (i == 3)
        {
            score3.text = "20";
            if (i == 4)
            {
                score4.text = "20";
            }
        }

        PlayerData.Score = new int[i];
        
        PlayerData.Score[0] = 20;
        PlayerData.Score[1] = 20;

        if (i == 3)
        {
            PlayerData.Score[2] = 20;
            if (i == 4)
            {
                PlayerData.Score[3] = 20;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        score1.text = PlayerData.Score[0].ToString();
        score2.text = PlayerData.Score[1].ToString();

        if (i == 3)
        {
            score3.text = PlayerData.Score[2].ToString(); 
            if (i == 4)
            {
                score4.text = PlayerData.Score[3].ToString();
            }
        }
        
 
    }
    
}

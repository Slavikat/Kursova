using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToGame : MonoBehaviour
{
    public GameObject RunGame;
    public GameObject Current;
    public GameObject Next;
    static int i=0;
    public InputField InName;
    public GameObject PanelZ;
    public GameObject Pl1;
    public GameObject Pl2;
    public GameObject Pl3;
    public GameObject Pl4;

    public Image PanelPl1;
    public Image PanelPl2;
    public Image PanelPl3;
    public Image PanelPl4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setColorR()
    {
        Utils("red");
    }
    public void setColorG()
    {
        Utils("green");
    }
    public void setColorB()
    {
        Utils("blue");
    }
    public void setColorY()
    {
        Utils("yellow");
    }
    public void Utils(string color)
    {
        PlayerData.Color[i] = color;
    }

    public void GoGame()
    {

          
       // PanelZ.localScale = new Vector3(0, 0);
        if (i < PlayerData.sumPlayer)
        {
            PlayerData.Name[i] = InName.text;
            InName.text = string.Empty;
            //     InName.text =i.ToString();
            i++;
        }

        if (i == PlayerData.sumPlayer)
        {
            

            RunGame.SetActive(false);
            Current.SetActive(false);
            Next.SetActive(true);
            Pl1.SetActive(true);
            Pl2.SetActive(true);

            if (PlayerData.sumPlayer >= 3)
            {
                  Pl3.SetActive(true);
                if (PlayerData.sumPlayer == 4)
                {
                     Pl4.SetActive(true);
                }
            }


          
           
            Image img = GameObject.Find("Panel (1)").GetComponent<Image>();
        
            img.color = UnityEngine.Color.clear;


            Utils2(0, PanelPl1);
            Utils2(1, PanelPl2);
            if (PlayerData.sumPlayer >= 3)
            {

                Utils2(3, PanelPl3);
                if (PlayerData.sumPlayer == 4)
                {

                    Utils2(3, PanelPl4);
                }
            }
            
        }

        
    }

    void Utils2(int j, Image panel)
    {
        switch (PlayerData.Color[j])
        {
            case "red":
                panel.color = UnityEngine.Color.red;
                break;
            case "yellow":
                panel.color = UnityEngine.Color.yellow;
                break;
            case "blue":
                panel.color = UnityEngine.Color.blue;
                break;
            case "green":
                panel.color = UnityEngine.Color.green;
                break;
        }
    }
   

}

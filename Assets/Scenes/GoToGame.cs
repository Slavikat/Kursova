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

    public Button setColorRed;
    public Button setColorBlue;
    public Button setColorGreen;
    public Button setColorYellow;

    bool g, r, y, b;

    bool col = false;

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
        //     setColorRed.interactable = false;
        r = true;
        Utils("red");
    }
    public void setColorG()
    {
        g = true;
     //   setColorGreen.interactable = false;
        Utils("green");
    }
    public void setColorB()
    {
        b = true;
    //    setColorBlue.interactable = false;
        Utils("blue");
    }
    public void setColorY()
    {
        y = true;
     //   setColorYellow.interactable = false;
        Utils("yellow");
    }
    public void Utils(string color)
    {
        PlayerData.Color[i] = color;

        col = true;
    }

    public void GoGame()
    {

        if (!col)
        {
            if (!r)
            {
                Utils("red");
                r = true;
            }
            else if (!g)
            {
                Utils("green");
                g = true;
            }
            else if (!b)
            {
                Utils("blue");
                b = true;
            }
            else if (!y)
            {
                Utils("yellow");
                y = true;
            }
        }
        col = false;

        if (r)
        {
            setColorRed.interactable = false;
        }
        if (g)
        {
            setColorGreen.interactable = false;
        }
        if (b)
        {
            setColorBlue.interactable = false;
        }
        if (y)
        {
            setColorYellow.interactable = false;
        }

        // PanelZ.localScale = new Vector3(0, 0);
        if (i < PlayerData.sumPlayer)
        {
            if (InName.text.Length > 0)
            {
            PlayerData.Name[i] = InName.text;
            }
            else
            {
                PlayerData.Name[i] = "Гравець "+ (i+1).ToString();
            }
            InName.text = string.Empty;
            i++;
        }

   //     if (!col)
   //     {
    /*        for(int j=i; j==0; j--)
            {
                if (PlayerData.Name[j] != "red") {
                    setColorRed.interactable = false;
                    Utils("red");
                }

                if (PlayerData.Name[j] != "green") setColorG();

                if (PlayerData.Name[j] != "blue") setColorB();

                if (PlayerData.Name[j] != "yellow") setColorY();
            }*/
     //   }
     //   col = false;

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

                Utils2(2, PanelPl3);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToGame : MonoBehaviour
{
    public GameObject RunGame;
    public GameObject Registration;
    public GameObject Current;
    public GameObject Next;
    static int i=0;
    public InputField InName;
    public GameObject PanelZ;

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
            //Registration.SetActive(false);
            Current.SetActive(false);
            Next.SetActive(true);
            Image img = GameObject.Find("Panel (1)").GetComponent<Image>();
        
            img.color = UnityEngine.Color.clear;
            //     PanelZ.color.a = 0;
        }

        
    }
   

}

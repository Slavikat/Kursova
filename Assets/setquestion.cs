using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class setquestion : MonoBehaviour
{
    public Text changeText;
    public Text perevirka;
    public string[] text;
    bool newText=true;
    int k;

    string vidpov;
    public int points=10;

    int btn;
    Random rand = new Random();
  


   
   
       public void onClick1()
    {
         btn = 1;
        Point();
    }


    public void onClick2()
    {
        btn = 2;
        Point();
    }


    public void onClick3()
    {
        btn = 3;
        Point();
    }

    string color = "braun";

    void Start()
    {
        int temp = Random.Range(1, 10);

        /*
        changeText.text= System.IO.File.ReadAllText("Assets/atmo/"+temp+ ".txt");
        vidpov = System.IO.File.ReadAllText("Assets/vidpov_a/" + temp + ".txt");
        */
        
        changeText.text = System.IO.File.ReadAllText("Assets/atmo/" + temp + ".txt");
         vidpov= System.IO.File.ReadAllText("Assets/vidpova/" + temp + ".txt");
        k = int.Parse(vidpov);
       
       /*
        changeText.text = System.IO.File.ReadAllText("Assets/capital/" + temp + ".txt");
        vidpov = System.IO.File.ReadAllText("Assets/vidpov_cap/" + temp + ".txt");
        k = int.Parse(vidpov);
        */
        /*
        switch (color)
        {
            case "braun":
                changeText.text = System.IO.File.ReadAllText("Assets/litos/" + temp + ".txt");
                vidpov = System.IO.File.ReadAllText("Assets/vidpov_l/" + temp + ".txt");
                break;

            case "light_blue":
                changeText.text = System.IO.File.ReadAllText("Assets/atmo/" + temp + ".txt");
                vidpov = System.IO.File.ReadAllText("Assets/vidpov_a/" + temp + ".txt");
                break;

            case "blue":
                changeText.text = System.IO.File.ReadAllText("Assets/hidro/" + temp + ".txt");
                vidpov = System.IO.File.ReadAllText("Assets/vidpov_h/" + temp + ".txt");
                break;

            case "green":
                changeText.text = System.IO.File.ReadAllText("Assets/bio/" + temp + ".txt");
                vidpov = System.IO.File.ReadAllText("Assets/vidpov_b/" + temp + ".txt");
                break;

            case "yellow":
                changeText.text = System.IO.File.ReadAllText("Assets/capital/" + temp + ".txt");
                vidpov = System.IO.File.ReadAllText("Assets/vidpov_cap/" + temp + ".txt");
                break;


            case "poznach":
                //відкрити іншу панель
                break;

            case "time":
                //відкрити іншу панель
                break;
        }

        perevirka.text = vidpov;
        */

    }



    public void Point()
    {
        
        if (k==btn)
        {
            //!!!!!!!!!! нарахування балів!!!!!!!!!!
            points += 10;
            
        }
        else
        {
                points -= 5;
            if (points < 5) { points = 0; } 
        }

        perevirka.text = points.ToString(); 
        // perevirka.text = points.ToString();

    }

    
    // Update is called once per frame
    void Update()
    {
       
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class setquestion2 : MonoBehaviour
{
    public Text changeText;
    public Text perevirka, per2;
   // public Image img;

  

    bool newText=true;
    int k;

    string vidpov;
    public int points=10;

    int btn=0;
    Random rand = new Random();
  


    string color = "braun";

    int temp;
    // string v1, v2, v3, v4, v5;

    public static string[] v1 = new string[10];
    public static string[] v2 = new string[10];
    public static string[] v3 = new string[10];
    public static string[] v4 = new string[10];
    public static string[] v5 = new string[10];


    void Start()
    {

        temp = Random.Range(1, 10);
     
      



        /*
        changeText.text= System.IO.File.ReadAllText("Assets/atmo/"+temp+ ".txt");
        vidpov = System.IO.File.ReadAllText("Assets/vidpov_a/" + temp + ".txt");
        */
        /*
        changeText.text = System.IO.File.ReadAllText("Assets/atmo/" + temp + ".txt");
        vidpov= System.IO.File.ReadAllText("Assets/vidpova/" + temp + ".txt");
        k = int.Parse(vidpov);
        //perevirka.text = k.ToString();
        */

        changeText.text = System.IO.File.ReadAllText("Assets/capital/" + temp + ".txt");
         vidpov = System.IO.File.ReadAllText("Assets/vidpov_cap/" + temp + ".txt");
         k = int.Parse(vidpov);



        // img.sprite = System.IO.File.Open("Assets/photo/" + temp + ".png");

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

    public void Point()
    {
        //perevirka.text = points.ToString();

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


        //  perevirka.text = btn.ToString();

        
        perevirka.text = k.ToString();
       // per2.text = .ToString();
        btn = 0;
        temp = 0;
        k = 0;


    }

    
    // Update is called once per frame
    void Update()
    {
       
    }


}

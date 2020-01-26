using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class setquestion2 : MonoBehaviour
{
    public Text changeText;
    public GameObject setQuestion;
    public GameObject GameScene;
    public GameObject panel;
    public GameObject panel1;
    public GameObject resultat;
    public static  bool start;
    bool stop=true;

    // public Image img;



    bool newText=true;
    static int k;

    static int vidpov;
    static public int points=10;

    static int btn;
    Random rand = new Random();
  


    string color = "braun";

    int temp;

    public static int[] v1 = new int[10];
    public static int[] v2 = new int[10];
    public static int[] v3 = new int[10];
    public static int[] v4 = new int[10];
    public static int[] v5 = new int[10];

 

    void Start()
    {


        v1[0] = 1;
        v1[1] = 3;
        v1[2] = 2;
        v1[3] = 1;
        v1[4] = 2;
        v1[5] = 3;
        v1[6] = 3;
        v1[7] = 1;
        v1[8] = 2;
        v1[9] = 3;

        v2[0] = 2;
        v2[1] = 2;
        v2[2] = 3;
        v2[3] = 3;
        v2[4] = 3;
        v2[5] = 2;
        v2[6] = 1;
        v2[7] = 1;
        v2[8] = 1;
        v2[9] = 1;

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

       

    }
    void Update()
    {
        if (start)
        {
temp = Random.Range(1, 10);
        changeText.text = System.IO.File.ReadAllText("Assets/capital/" + temp + ".txt");
        // vidpov = System.IO.File.ReadAllText("Assets/vidpov_cap/" + temp + ".txt");
        vidpov = v1[temp - 1];
            start = !start;
        }
        
    }

    public void onClick1()
    {
        btn = 1;
        Point();

        if (stop) Utils();
}

    void Utils()
    {
setQuestion.SetActive(false);
    GameScene.SetActive(true);
     panel.SetActive(false);
    }
    public void onClick2()
    {
        btn = 2;
        Point();
        if (stop) Utils();
    }


    public void onClick3()
    {
        btn = 3;
        Point();
        if(stop)
        Utils();
    }

    public void Point()
    {
        //perevirka.text = points.ToString();

        if (vidpov==btn)
        {
            PlayerData.Score[PlayerData.play] += 10;
            //!!!!!!!!!! нарахування балів!!!!!!!!!!
            //        points += 10;

        }
        else
        {
            PlayerData.Score[PlayerData.play] -= 5;
            //           points -= 5;
                   if (PlayerData.Score[PlayerData.play] < 5) { PlayerData.Score[PlayerData.play] = 0; } 
  
        }
        if (PlayerData.Score[PlayerData.play] >= 30)
        {
            resultat.SetActive(true);
            panel1.SetActive(true);

            GameScene.SetActive(false);
            setQuestion.SetActive(false);
            panel.SetActive(false);
           stop = false;
        }
        //      if (PlayerData.Score[PlayerData.play]>=)
        //  perevirka.text = btn.ToString();



        // per2.text = .ToString();



    }

    
    // Update is called once per frame
  

}

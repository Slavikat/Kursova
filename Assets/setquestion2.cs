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

    

    bool newText=true;
    static int k;

    static int vidpov;
    static public int points=10;

    static int btn;
    Random rand = new Random();
  


    string color = "braun";
    public static int rozd;
    int temp;

    public static int[] v1cap = new int[10];
    public static int[] v2atmo = new int[10];
    public static int[] v3bio = new int[10];
    public static int[] v4hidro = new int[10];
    public static int[] v5litos = new int[10];
  
 

    void Start()
    {


        v1cap[0] = 1;
        v1cap[1] = 3;
        v1cap[2] = 2;
        v1cap[3] = 1;
        v1cap[4] = 2;
        v1cap[5] = 3;
        v1cap[6] = 3;
        v1cap[7] = 1;
        v1cap[8] = 2;
        v1cap[9] = 3;

        v2atmo[0] = 2;
        v2atmo[1] = 2;
        v2atmo[2] = 3;
        v2atmo[3] = 3;
        v2atmo[4] = 3;
        v2atmo[5] = 2;
        v2atmo[6] = 1;
        v2atmo[7] = 1;
        v2atmo[8] = 1;
        v2atmo[9] = 2;

        v3bio[0] = 3;
        v3bio[1] = 3;
        v3bio[2] = 3;
        v3bio[3] = 2;
        v3bio[4] = 3;
        v3bio[5] = 3;
        v3bio[6] = 1;
        v3bio[7] = 2;
        v3bio[8] = 1;
        v3bio[9] = 2;

        v4hidro[0] = 3;
        v4hidro[1] = 2;
        v4hidro[2] = 3;
        v4hidro[3] = 2;
        v4hidro[4] = 3;
        v4hidro[5] = 2;
        v4hidro[6] = 1;
        v4hidro[7] = 3;
        v4hidro[8] = 3;
        v4hidro[9] = 2;

        v5litos[0] = 2;
        v5litos[1] = 2;
        v5litos[2] = 2;
        v5litos[3] = 2;
        v5litos[4] = 1;
        v5litos[5] = 3;
        v5litos[6] = 3;
        v5litos[7] = 3;
        v5litos[8] = 1;
        v5litos[9] = 1;


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
        setQuest();
        
    }


    public bool[,] povtor=new bool[5,10];


    void setQuest()
    {
        if (start)
        {
        temp = Random.Range(1, 10);


            if (povtor[rozd, temp] == false) {
                
                changeText.text = System.IO.File.ReadAllText("Assets/"+rozd+"/" + temp + ".txt");
           
            switch (rozd)
            {
                case 1: 
                    vidpov = v1cap[temp - 1];
                    
                        break;
                case 2:
                    vidpov = v2atmo[temp - 1];
                    break;
                case 3:
                    vidpov = v3bio[temp - 1];
                    break;
                case 4:
                    vidpov = v4hidro[temp - 1];
                    break;
                case 5:
                    vidpov = v5litos[temp - 1];
                    break;
            } }
   

   
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

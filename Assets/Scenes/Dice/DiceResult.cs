using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceResult : MonoBehaviour
{
    public void Result()
    {
        DiceScript.roll = true;
        DiceScript2.roll = true;
    }
        /*  int result;
          public DiceRoll dice1;
          public DiceRoll2 dice2;
          int x = 0;
          void Start()
          {

          }
          public void Result()
          {

              x = 0;
                  dice1.setData();
                  dice2.setData();

              if (x!=2)
              {
                  Update();
              }

          }
          private void OnGUI()
          {
             if(x==2) Debug.Log(result + "rolled");
              string txt = result.ToString();
              GUILayout.Label(txt); 
          }
          void Update()
          {

                  if (dice1.get())
                  {
                      result += dice1.getValue();
                      dice1.set(false);
                      x++;
                  }
              if (dice2.get())
              {
                  result += dice2.getValue();
                  dice2.set(false);
                  x++;
              }


          }*/
    }

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoToGame : MonoBehaviour
{
    public GameObject RunGame;
    public GameObject Registration;
    static int i=0;
    public InputField InName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoGame()
    {
        
            if(i< PlayerData.sumPlayer)
        { 
            PlayerData.Name[i] = InName.text;
                InName.text = string.Empty;
       //     InName.text =i.ToString();
                i++;
       }
        if(i == PlayerData.sumPlayer)
        {
        RunGame.SetActive(false);
        Registration.SetActive(true);
        }
       
    }

   /* public void BackToRegistration()
    {
        RunGame.SetActive(true);
        Registration.SetActive(false);
    }*/

}

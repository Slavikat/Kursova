using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveTo : MonoBehaviour
{
    public GameObject ChoosePlayer;
    public GameObject UserRegistration;
    int pl;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Registration2()
    {
        pl = 2;
      
        Util();
    }
    public void Registration3()
    {
        pl = 3;
        Util();
    }
    public void Registration4()
    {
        pl = 4;
        Util();
    }
    public void Util()
    {
        PlayerData.sumPlayer = pl;
        PlayerData.Name = new string[pl];
        ChoosePlayer.SetActive(false);
        UserRegistration.SetActive(true);
    }

    public void ChoosePl()
    {
        ChoosePlayer.SetActive(true);
        UserRegistration.SetActive(false);
    }
}

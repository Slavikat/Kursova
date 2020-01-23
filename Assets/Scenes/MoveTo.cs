using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveTo : MonoBehaviour
{
    public GameObject ChoosePlayer;
    public GameObject UserRegistration;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Registration()
    {
        ChoosePlayer.SetActive(false);
        UserRegistration.SetActive(true);
    }

    public void ChoosePl()
    {
        ChoosePlayer.SetActive(true);
        UserRegistration.SetActive(false);
    }
}

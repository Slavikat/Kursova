using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoToTheGame : MonoBehaviour
{
    public GameObject RunGame;
    public GameObject Registration;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RunThisGame()
    {
        RunGame.SetActive(false);
        Registration.SetActive(true);
    }

}

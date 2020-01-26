using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToLVL_1 : MonoBehaviour
{
    public GameObject NewGame;
    public GameObject Choose;
    public GameObject Help;
    public GameObject Exit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChoosePlayers()
    {
        Help.SetActive(false);
        Exit.SetActive(false);
        NewGame.SetActive(false);
        Choose.SetActive(true);
    }

    public void BackToMenu()
    {
        NewGame.SetActive(true);
        Choose.SetActive(false);
    }
}

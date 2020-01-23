using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveToChoose : MonoBehaviour
{
    public GameObject NewGame;
    public GameObject ChoosePlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChoosePlay()
    {
        NewGame.SetActive(false);
        ChoosePlay.SetActive(true);
    }

    public void BackToMenu()
    {
        NewGame.SetActive(true);
        ChoosePlay.SetActive(false);
    }
}

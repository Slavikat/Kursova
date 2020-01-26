using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveUpControl : MonoBehaviour
{
    public GameObject GiveUp;
    public GameObject End;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GiveUpMenu()
    {
        GiveUp.SetActive(false);
        End.SetActive(true);
    }

    public void ReturnToGame()
    {
        GiveUp.SetActive(true);
        End.SetActive(false);
    }

    public void EndGame()
    {
        Application.Quit();
    }
}

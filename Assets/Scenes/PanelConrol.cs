using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelConrol : MonoBehaviour
{
    public GameObject start;
    public GameObject end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PanelEnd()
    {
        start.SetActive(false);
        end.SetActive(true);
    }

    public void PanelStart()
    {
        start.SetActive(true);
        end.SetActive(false);
    }

}

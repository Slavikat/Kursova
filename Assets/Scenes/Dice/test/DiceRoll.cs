using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DiceRoll : MonoBehaviour
{
    Rigidbody rb;
    bool hasLanded;
    bool thrown=true;
    public int diceValue;
    public DiceSide[] diceSides;
    bool end = false;
    static Vector3 initPosition;

    public void setData()
    {
        thrown = false;
        rb.useGravity = true;
        rb.position = new Vector3(5.41f, 1.52f, -4.1f); 
    }

    public bool get()
    {
        return end;
    }
    public int getValue()
    {
        return diceValue;
    }

    public void set(bool th)
    {
        end = th;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initPosition = transform.position;
    }

    void Update()
    {
        if (!thrown )
        {
            RollDice();
        }
        if (rb.IsSleeping() && thrown)
        {
            SideValueCheck();
    //        Reset();
        }
    }



    public void RollDice()
    {
        if(!thrown)
        {
            thrown = true;
            rb.useGravity = true;
            rb.AddTorque(Random.Range(0,500), Random.Range(0, 500), Random.Range(0, 500));

        }
    }

    void SideValueCheck()
    {
        diceValue = 0;
        foreach(DiceSide side in diceSides)
        {
            if(side.getOnGround())
            {
                diceValue = side.sideValue;
                //Debug.Log(diceValue + "rolled");
                end = true;
                rb.useGravity = false;
            }
        }
    }

}

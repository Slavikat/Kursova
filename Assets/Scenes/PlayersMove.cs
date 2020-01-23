﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersMove : MonoBehaviour
{

    public Route currentRoute;

    int routePosition;

    public int steps;

    public int i;

    bool isMoving;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isMoving)
        {
            steps = DiceNumberTextScript.diceNumber;
            Debug.Log(" Dice Rolled " + steps);

            StartCoroutine(Move());
            //if(routePosition + steps< currentRoute.childNodeList.Count)
            //{
            //    StartCoroutine(Move());
            //}
            //else
            //{
            //    Debug.Log(" Rolled Number Is To High");
            //}
        }
    }

    IEnumerator Move()
    {
        if (isMoving)
        {
            yield break;
        }
        isMoving = true;

        while (steps > 0)
        {
            routePosition++;
            routePosition %= currentRoute.childNodeList.Count;

            Vector3 nextPos = currentRoute.childNodeList[routePosition].position;
            while (MoveToNextNode(nextPos))
            {
                yield return null;
            }

            yield return new WaitForSeconds(0.1f);
            steps--;
            //routePosition++;
        }
        isMoving = false;

    }

    bool MoveToNextNode(Vector3 goal)
    {
        return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 2f * Time.deltaTime));
    }
}

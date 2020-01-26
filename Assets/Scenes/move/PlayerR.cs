using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerR : MonoBehaviour
{
    public RouteR currentRoute;

    int routePosition;

    public int steps;

    void Update()
    {

        if (Moved.plR)
        {
            
            steps = DiceNumberTextScript.diceNumber;
            Debug.Log("Dice Rolled " + steps);

            StartCoroutine(Move());
            Moved.plR = false;
        }
    }
    IEnumerator Move()
    {
        if (Moved.isMoving)
        {
            yield break;
        }
        Moved.isMoving = true;

        while (steps > 0)
        {
            routePosition++;
            routePosition %= currentRoute.childNodeList.Count;
            Vector3 nextPos = currentRoute.childNodeList[routePosition].position;
            while (MoveToNextNode(nextPos)) { yield return null; }

            yield return new WaitForSeconds(0.1f);
            steps--;
            //routePosition++;
        }
        PlayerData.stop = true;
        Moved.isMoving = false;
    }

    bool MoveToNextNode(Vector3 goal)
    {
        return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 2f * Time.deltaTime));
    }
}

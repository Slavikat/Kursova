using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerG : MonoBehaviour
{
    public GameObject setQuestion3;
    public GameObject GameScene3;
    public GameObject panel;
    public GameObject panel1;

    public GameObject resultat;

    int routePosition;
 public RouteG currentRoute;
    public int steps;

    void Update()
    {
        if (Moved.plG)
        {
            
            steps = DiceNumberTextScript.diceNumber;
            Debug.Log("Dice Rolled " + steps);

            StartCoroutine(Move());
            Moved.plG = false;
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
        Perev();
        Moved.isMoving = false;
        }
    public void Perev()
    {
        if (PlayerData.stop)
        {
            PlayerData.stop = false;

            Pyt();
        }

    }
    public void Pyt()
    {
        Quest(PlayerData.Klitynka[PlayerData.play] - 1);
       
    }

    void Utils()
    {
        if (PlayerData.Score[PlayerData.play] >= 30)
        {
            resultat.SetActive(true);
            panel1.SetActive(true);

            GameScene3.SetActive(false);
            setQuestion3.SetActive(false);
            panel.SetActive(false);
        }
    }



    void questScene(int roz)
    {
        setquestion2.rozd = roz;
        GameScene3.SetActive(false);
        setQuestion3.SetActive(true);
        panel.SetActive(true);

        setquestion2.start = true;
    }

    public void Quest(int k)
    {


        if (PlayerData.Pola[k] == "v")
        {
            int rozd = Random.Range(1, 5);
            PlayerData.Pola[k] = rozd.ToString();
        }

        switch (PlayerData.Pola[k])
        {

            case "1":

                questScene(1);
                Utils();

                break;
            case "2":

                questScene(2);
                Utils();
                break;
            case "3":

                questScene(3);
                Utils();
                break;

            case "4":
                questScene(4);
                Utils();
                break;
            case "5":
                questScene(5);
                Utils();
                break;
            case "p":

                break;
            case "+5":
                PlayerData.Score[PlayerData.play] += 5;
                Utils();
                break;
            case "-5":
                PlayerData.Score[PlayerData.play] -= 5;
                Utils();
                break;
            case "+15":
                PlayerData.Score[PlayerData.play] += 15;
                Utils();
                break;
            case "-15":
                PlayerData.Score[PlayerData.play] -= 15;
                Utils();
                break;
            case "st":
                PlayerData.Score[PlayerData.play] += 5;
                Utils();
                break;

        }

    }

    bool MoveToNextNode(Vector3 goal)
        {
            return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 2f * Time.deltaTime));
        }
   
}

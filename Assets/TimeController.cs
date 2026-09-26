using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeController : MonoBehaviour
{
    public float timeRemainder = 30;
    public Text TimeLabel;
    // Start is called before the first frame update
    void Start()
    {
        this.DisplayTime();
    }

    // Update is called once per frame
    void Update()
    {
        timeRemainder -= Time.deltaTime;
        this.DisplayTime();

        if (timeRemainder < 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    void DisplayTime()
    {
        TimeLabel.text = timeRemainder.ToString("0");
    }

    public void GoalReached()
    {
        if (timeRemainder > 0)
        {
            SceneManager.LoadScene("Main Game Introduction");
        }
    }

    public void CalculateTime(string init, string dest)
    {
        //Debug.Log(init + " " + dest);

        //if ((init == "start" && dest == "11") || (init == "11" && dest == "start"))
        //{
        //    timeCost = 4;
        //} 
        //else if ((init == "start" && dest == "12") || (init == "12" && dest == "start"))
        //{
        //    timeCost = 3;
        //}
        //else if ((init == "11" && dest == "21") || (init == "21" && dest == "11"))
        //{
        //    timeCost = 6;
        //}
        //else if ((init == "11" && dest == "22") || (init == "22" && dest == "11"))
        //{
        //    timeCost = 1;
        //}
        //else if ((init == "12" && dest == "23") || (init == "23" && dest == "12"))
        //{
        //    timeCost = 2;
        //}
        //else if (init == "12" && dest == "goal")
        //{
        //    timeCost = 7;
        //}
        //else if (init == "21" && dest == "goal")
        //{
        //    timeCost = 8;
        //}
        //else if (init == "23" && dest == "goal")
        //{
        //    timeCost = 2;
        //}
        //else
        //{
        //    timeCost = 0;
        //}

        float timeCost = Random.Range(3, 7);
        this.timeRemainder -= timeCost;
    }
}

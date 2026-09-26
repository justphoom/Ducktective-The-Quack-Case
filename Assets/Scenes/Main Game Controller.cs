using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainGameController : MonoBehaviour
{

    public GameObject start;
    public GameObject goal;
    public GameObject placeA;
    public GameObject placeB;
    public GameObject placeC;
    public GameObject placeD;
    public GameObject placeE;
    public GameObject placeF;
    public GameObject placeG;
    public GameObject placeH;
    public GameObject placeI;

    public float timeRemainder = 60;
    public Text TimeLabel;

    // Start is called before the first frame update
    void Start()
    {
        start.SetActive(true);
        goal.SetActive(false);
        placeA.SetActive(false);
        placeB.SetActive(false);
        placeC.SetActive(false);
        placeD.SetActive(false);
        placeE.SetActive(false);
        placeF.SetActive(false);
        placeG.SetActive(false);
        placeH.SetActive(false);
        placeI.SetActive(false);

        DisplayTime();
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

    public void OnClickStart()
    {
        CalculateTime();
        start.SetActive(false);
        goal.SetActive(false);
        placeA.SetActive(true);
        placeB.SetActive(false);
        placeC.SetActive(false);
        placeD.SetActive(false);
        placeE.SetActive(false);
        placeF.SetActive(false);
        placeG.SetActive(false);
        placeH.SetActive(false);
        placeI.SetActive(false);
    }
    
    public void OnClickGoal()
    {
        CalculateTime();
        Debug.Log("Goal Reached");
        start.SetActive(false);
        goal.SetActive(true);
        placeA.SetActive(false);
        placeB.SetActive(false);
        placeC.SetActive(false);
        placeD.SetActive(false);
        placeE.SetActive(false);
        placeF.SetActive(false);
        placeG.SetActive(false);
        placeH.SetActive(false);
        placeI.SetActive(false);
        GoalReached();
    }

    public void OnClickPlaceA(){
        CalculateTime();
        start.SetActive(false);
        goal.SetActive(false);
        placeA.SetActive(false);
        placeD.SetActive(false);
        placeE.SetActive(false);
        placeF.SetActive(false);
        placeG.SetActive(false);
        placeH.SetActive(false);
        placeI.SetActive(false);


        float isOpen;
        bool isAllClosed = true;

        isOpen = Random.Range(0, 2);
        if (isOpen > 0)
        {
            placeB.SetActive(true);
            isAllClosed = false;
        }
        else
        {
            placeB.SetActive(false);
        }

        if (isAllClosed)
        {
            placeC.SetActive(true);
        }
        else
        {
            isOpen = Random.Range(0, 2);
            if (isOpen > 0)
            {
                placeC.SetActive(true);
            }
            else
            {
                placeC.SetActive(false);
            }
        }
    }

    public void OnClickPlaceB(){
        CalculateTime();
        start.SetActive(false);
        goal.SetActive(false);
        placeB.SetActive(false);
        placeE.SetActive(false);
        placeF.SetActive(false);
        placeG.SetActive(false);
        placeH.SetActive(false);
        placeI.SetActive(false);


        float isOpen;
        bool isAllClosed = true;

        isOpen = Random.Range(0, 2);
        if (isOpen > 0)
        {
            isAllClosed = false;
            // true
            placeA.SetActive(true);
        }
        else
        {
            // false
            placeA.SetActive(false);
        }

        isOpen = Random.Range(0, 2);
        if (isOpen > 0)
        {
            isAllClosed = false;
            // true
            placeA.SetActive(true);
        }
        else
        {
            // false
            placeA.SetActive(false);
        }
        placeC.SetActive(true);


        if (isAllClosed)
        {
            placeD.SetActive(true);
        }
        else
        {
            isOpen = Random.Range(0, 2);
            if (isOpen > 0)
            {
                // true
                placeD.SetActive(true);
            }
            else
            {
                // false
                placeD.SetActive(false);
            }
        }
        

    }

    public void OnClickPlaceC(){
        CalculateTime();
        start.SetActive(false);
        goal.SetActive(false);
        placeC.SetActive(false);
        placeD.SetActive(false);
        placeF.SetActive(false);
        placeI.SetActive(false);

        float isOpen;
        bool isAllClosed = true;

        isOpen = Random.Range(0, 2);
        if (isOpen > 0)
        {
            isAllClosed = false;
            // true
            placeA.SetActive(true);
        }
        else
        {
            // false
            placeA.SetActive(false);
        }

        isOpen = Random.Range(0, 2);
        if (isOpen > 0)
        {
            isAllClosed = false;
            // true
            placeB.SetActive(true);
        }
        else
        {
            // false
            placeB.SetActive(false);
        }

        isOpen = Random.Range(0, 2);
        if (isOpen > 0)
        {
            isAllClosed = false;
            // true
            placeE.SetActive(true);
        }
        else
        {
            // false
            placeE.SetActive(false);
        }

        isOpen = Random.Range(0, 2);
        if (isOpen > 0)
        {
            isAllClosed = false;
            // true
            placeG.SetActive(true);
        }
        else
        {
            // false
            placeG.SetActive(false);
        }


        if (isAllClosed)
        {
            placeH.SetActive(true);
        }
        else
        {
            isOpen = Random.Range(0, 2);
            if (isOpen > 0)
            {
                isAllClosed = false;
                // true
                placeH.SetActive(true);
            }
            else
            {
                // false
                placeH.SetActive(false);
            }

        }

    }

    public void OnClickPlaceD(){
        CalculateTime();
        start.SetActive(false);
        goal.SetActive(false);
        placeA.SetActive(false);
        placeC.SetActive(false);
        placeD.SetActive(false);
        placeF.SetActive(false);
        placeG.SetActive(false);
        placeH.SetActive(false);
        placeI.SetActive(false);

        float isOpen;
        bool isAllClosed = true;

        isOpen = Random.Range(0, 2);
        if (isOpen > 0)
        {
            isAllClosed = false;
            // true
            placeB.SetActive(true);
        }
        else
        {
            // false
            placeB.SetActive(false);
        }

        if (isAllClosed)
        {
            placeE.SetActive(true);
        }
        else
        {
            isOpen = Random.Range(0, 2);
            if (isOpen > 0)
            {
                isAllClosed = false;
                // true
                placeE.SetActive(true);
            }
            else
            {
                // false
                placeE.SetActive(false);
            }

        }

    }

    public void OnClickPlaceE(){
        CalculateTime();
        start.SetActive(false);
        goal.SetActive(false);
        placeA.SetActive(false);
        placeB.SetActive(false);
        placeE.SetActive(false);
        placeG.SetActive(false);
        placeH.SetActive(false);
        placeI.SetActive(false);

        float isOpen;
        bool isAllClosed = true;

        isOpen = Random.Range(0, 2);
        if (isOpen > 0)
        {
            isAllClosed = false;
            // true
            placeC.SetActive(true);
        }
        else
        {
            // false
            placeC.SetActive(false);
        }

        isOpen = Random.Range(0, 2);
        if (isOpen > 0)
        {
            isAllClosed = false;
            // true
            placeD.SetActive(true);
        }
        else
        {
            // false
            placeD.SetActive(false);
        }

        if (isAllClosed)
        {
            placeF.SetActive(true);
        }
        else
        {
            isOpen = Random.Range(0, 2);
            if (isOpen > 0)
            {
                isAllClosed = false;
                // true
                placeF.SetActive(true);
            }
            else
            {
                // false
                placeF.SetActive(false);
            }

        }

    }

    public void OnClickPlaceF(){
        CalculateTime();
        start.SetActive(false);
        goal.SetActive(false);
        placeA.SetActive(false);
        placeB.SetActive(false);
        placeC.SetActive(false);
        placeD.SetActive(false);
        placeF.SetActive(false);
        placeH.SetActive(false);
        placeI.SetActive(false);

        float isOpen;
        bool isAllClosed = true;

        isOpen = Random.Range(0, 2);
        if (isOpen > 0)
        {
            isAllClosed = false;
            // true
            placeE.SetActive(true);
        }
        else
        {
            // false
            placeE.SetActive(false);
        }


        if (isAllClosed)
        {
            placeG.SetActive(true);
        }
        else
        {
            isOpen = Random.Range(0, 2);
            if (isOpen > 0)
            {
                isAllClosed = false;
                // true
                placeG.SetActive(true);
            }
            else
            {
                // false
                placeG.SetActive(false);
            }

        }

    }

    public void OnClickPlaceG(){
        CalculateTime();
        start.SetActive(false);
        placeA.SetActive(false);
        placeB.SetActive(false);
        placeD.SetActive(false);
        placeE.SetActive(false);
        placeG.SetActive(false);
        placeI.SetActive(false);

        float isOpen;
        bool isAllClosed = true;
        isOpen = Random.Range(0, 1);
    if (isOpen > 0.5)
        {
            isAllClosed = false;
            // true
            goal.SetActive(true);
        }
        else
        {
            // false
            goal.SetActive(false);
        }


        isOpen = Random.Range(0, 2);
        if (isOpen > 0)
        {
            isAllClosed = false;
            // true
            placeC.SetActive(true);
        }
        else
        {
            // false
            placeC.SetActive(false);
        }

        isOpen = Random.Range(0, 2);
        if (isOpen > 0)
        {
            isAllClosed = false;
            // true
            placeF.SetActive(true);
        }
        else
        {
            // false
            placeF.SetActive(false);
        }

        if (isAllClosed)
        {
            placeH.SetActive(true);
        }
        else
        {
            isOpen = Random.Range(0, 2);
            if (isOpen > 0)
            {
                isAllClosed = false;
                // true
                placeH.SetActive(true);
            }
            else
            {
                // false
                placeH.SetActive(false);
            }

        }

    }

    public void OnClickPlaceH(){
        CalculateTime();
        start.SetActive(false);
        placeA.SetActive(false);
        placeB.SetActive(false);
        placeD.SetActive(false);
        placeE.SetActive(false);
        placeF.SetActive(false);
        placeH.SetActive(false);

        float isOpen;
        bool isAllClosed = true;

        isOpen = Random.Range(0, 2);
        if (isOpen > 0)
        {
            isAllClosed = false;
            // true
            goal.SetActive(true);
        }
        else
        {
            // false
            goal.SetActive(false);
        }

        
        isOpen = Random.Range(0, 2);
        if (isOpen > 0)
        {
            isAllClosed = false;
            // true
            placeC.SetActive(true);
        }
        else
        {
            // false
            placeC.SetActive(false);
        }
        
        isOpen = Random.Range(0, 2);
        if (isOpen > 0)
        {
            isAllClosed = false;
            // true
            placeG.SetActive(true);
        }
        else
        {
            // false
            placeG.SetActive(false);
        }

        if (isAllClosed)
        {
            placeI.SetActive(true);
        }
        else
        {
            isOpen = Random.Range(0, 2);
            if (isOpen > 0)
            {
                isAllClosed = false;
                // true
                placeI.SetActive(true);
            }
            else
            {
                // false
                placeI.SetActive(false);
            }

        }

    }

    public void OnClickPlaceI(){
        CalculateTime();
        start.SetActive(false);
        placeA.SetActive(false);
        placeB.SetActive(false);
        placeC.SetActive(false);
        placeD.SetActive(false);
        placeE.SetActive(false);
        placeF.SetActive(false);
        placeG.SetActive(false);
        placeI.SetActive(false);

        float isOpen;
        bool isAllClosed = true;

        isOpen = Random.Range(0, 2);
        if (isOpen > 0)
        {
            isAllClosed = false;
            // true
            goal.SetActive(true);
        }
        else
        {
            // false
            goal.SetActive(false);
        }

        if (isAllClosed)
        {
            placeH.SetActive(true);
        }
        else
        {
            isOpen = Random.Range(0, 2);
            if (isOpen > 0)
            {
                isAllClosed = false;
                // true
                placeH.SetActive(true);
            }
            else
            {
                // false
                placeH.SetActive(false);
            }

        }

    }

    void CalculateTime()
    {
        float timeCost = Random.Range(3, 7);
        this.timeRemainder -= timeCost;
    }

    void DisplayTime()
    {
        TimeLabel.text = timeRemainder.ToString("0");
    }

    void GoalReached()
    {
        if (timeRemainder > 0)
        {
            Debug.Log("Victory");
            SceneManager.LoadScene("Victory");
        }
    }
}

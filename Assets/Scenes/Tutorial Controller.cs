using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    public GameObject start;
    public GameObject goal;
    public GameObject placeA;
    public GameObject placeB;
    public GameObject placeC;
    public GameObject placeD;
    
    private string initPlace = string.Empty;
    private string destPlace = string.Empty;

    public TimeController time;

    // Start is called before the first frame update
    void Start()
    {
        time = GameObject.FindGameObjectWithTag("Time").GetComponent<TimeController>();

        start.SetActive(true);
        goal.SetActive(false);
        placeA.SetActive(false);
        placeB.SetActive(false);
        placeC.SetActive(false);
        placeD.SetActive(false);
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
    }

    public void OnClickPlaceA()
    {
        CalculateTime();

        start.SetActive(false);
        goal.SetActive(false);
        placeA.SetActive(false);
        placeB.SetActive(true);
        placeC.SetActive(true);
        placeD.SetActive(true);
    }

    public void OnClickPlaceB()
    {
        CalculateTime();
        
        start.SetActive(false);
        goal.SetActive(false);
        placeA.SetActive(true);
        placeB.SetActive(false);
        placeC.SetActive(true);
        placeD.SetActive(false);
    }

    public void OnClickPlaceC()
    {
        CalculateTime();
        
        start.SetActive(false);
        goal.SetActive(true);
        placeA.SetActive(true);
        placeB.SetActive(true);
        placeC.SetActive(false);
        placeD.SetActive(false);
    }

    public void OnClickPlaceD()
    {
        CalculateTime();
        
        start.SetActive(false);
        goal.SetActive(true);
        placeA.SetActive(true);
        placeB.SetActive(false);
        placeC.SetActive(false);
        placeD.SetActive(false);
    }

    public void OnClickGoal()
    {
        CalculateTime();
        time.GoalReached();
    }

    void CalculateTime()
    {
        time.CalculateTime(initPlace, destPlace);
        initPlace = destPlace;
        destPlace = string.Empty;
    }
}

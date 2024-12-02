using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HeatLevelsLogic : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField]
    public float temprature;

    [SerializeField]
    GameObject player;

    PlayerHeatLogic phl;

    public string heatLevel;

    private float start;
    private float currentTime;




    void Start()
    {


        heatLevel = "MEDIUM";
        temprature = 0;
        start = 0;
        currentTime = 0;
        
        
        try
        {
            phl = player.GetComponent<PlayerHeatLogic>();

            temprature = phl.getHeat();

        }
        catch (Exception e)
        {

        }

    }

    // Update is called once per frame
    void Update()
    {

        float previousHeat = temprature;

        try
        {
            temprature = phl.getHeat();








        }
        catch (Exception e)
        {

        }
        float deltaTime = Time.deltaTime;
        currentTime += deltaTime;


        if(currentTime-start>=1f)
        {

            if(temprature - previousHeat>8)
            {
                heatLevel = "HIGH";
            }
            if(temprature - previousHeat <3)
            {
                heatLevel = "LOW";
            }
            else
            {
                heatLevel = "MEDIUM";
            }






        }

    }
    public string getHeatLevel()
    {
        return heatLevel;
    }
    public void setHeatLevel(string hl)
    {
        heatLevel = hl;
    }



}

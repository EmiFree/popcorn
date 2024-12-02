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

    private float targetTime = 1f;
    private float currentTime;




    void Start()
    {


        heatLevel = "MEDIUM";
        temprature = 0;
        targetTime = 1f;
        currentTime = 0;
        
        
        try
        {
            phl = player.GetComponent<PlayerHeatLogic>();

            temprature = phl.GetHeat();

        }
        catch (Exception e)
        {

        }

    }

    // Update is called once per frame
    void Update()
    {

        targetTime -= Time.deltaTime;
        float previousHeat = temprature;

        try
        {
            temprature = phl.GetHeat();








        }
        catch (Exception e)
        {

        }
        float deltaTime = Time.deltaTime;
        currentTime += deltaTime;


        if(targetTime <=0.0f)
        {

            print(temprature - previousHeat);

            if(temprature - previousHeat>.05)
            {
                heatLevel = "HIGH";
            }
            else if(temprature - previousHeat <.02)
            {
                heatLevel = "LOW";
            }
            else
            {
                heatLevel = "MEDIUM";
            }





            targetTime = 1f;
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

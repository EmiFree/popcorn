using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TempProbeText : MonoBehaviour
{
    [SerializeField]
    TMP_Text tempText;

    [SerializeField]
    public float temprature;

    [SerializeField]
    GameObject player;

    PlayerHeatLogic phl;


    // Start is called before the first frame update
    void Start()
    {
      temprature = 100;
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
        try
        {
            temprature = phl.GetHeat();


        }
        catch (Exception e)
        {

        }




        if(temprature>=100)
        {
            tempText.SetText("" + (int)temprature);
        }
        else if (temprature<100 && (int)temprature>=10)
        {
            tempText.SetText("0" + (int)temprature);
        }
        else
        {
            tempText.SetText("00" + (int)temprature);
        }
        


        
    }
    void setTemp(float tmep)
    {
        temprature = tmep;
    }



}

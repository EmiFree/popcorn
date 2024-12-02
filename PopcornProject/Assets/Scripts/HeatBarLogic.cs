using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class HeatBarLogic : MonoBehaviour
{
    [SerializeField]
    public float temprature;

    [SerializeField]
    GameObject player;

    PlayerHeatLogic phl;


    Image barImage;



    // Start is called before the first frame update
    void Start()
    {
        barImage = this.GetComponentInParent<Image>();

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


        float fillRatio = temprature/100f ;


        barImage.fillAmount = fillRatio;



    }

    void setTemp(int temp)
    {
        temprature = temp;

        if(temp ==0)
        {
            temprature = 1;
        }

    }

}

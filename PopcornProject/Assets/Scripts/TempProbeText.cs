using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TempProbeText : MonoBehaviour
{
    [SerializeField]
    TMP_Text tempText;

    [SerializeField]
    public int temprature;


    // Start is called before the first frame update
    void Start()
    {
      temprature = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(temprature>=100)
        {
            tempText.SetText("" + temprature);
        }
        else if (temprature<100 && temprature>=10)
        {
            tempText.SetText("0" + temprature);
        }
        else
        {
            tempText.SetText("00" + temprature);
        }
        


        
    }
    void setTemp(int tmep)
    {
        temprature = tmep;
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeatBarLogic : MonoBehaviour
{
    [SerializeField]
    public int temprature;

    Image barImage;



    // Start is called before the first frame update
    void Start()
    {
        barImage = this.GetComponentInParent<Image>();



    }

    // Update is called once per frame
    void Update()
    {
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

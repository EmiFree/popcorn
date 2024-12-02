using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnerLogic : MonoBehaviour
{
    [SerializeField]
    public string heatLevel;

    [SerializeField]
    Animator burnerAnimator;





    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        if (heatLevel.Equals("LOW")) 
        {

        }
        else if (heatLevel.Equals("MEDIUM")) 
        {

        }
        else
        {

        }





    }
}

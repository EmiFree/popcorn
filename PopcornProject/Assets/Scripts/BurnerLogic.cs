using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnerLogic : MonoBehaviour
{
    [SerializeField]
    public string heatLevel;

    [SerializeField]
    Animator burnerAnimator;

    [SerializeField]
    GameObject player;

    HeatLevelsLogic hll;




    // Start is called before the first frame update
    void Start()
    {

        burnerAnimator.speed = 0f;
        hll = player.GetComponent<HeatLevelsLogic>();

        heatLevel = hll.getHeatLevel();



    }

    // Update is called once per frame
    void Update()
    {
        heatLevel = hll.getHeatLevel();

        if (heatLevel.Equals("LOW")) 
        {
            burnerAnimator.Play("Burner_Large", 0, 0f);
        }
        else if (heatLevel.Equals("MEDIUM")) 
        {
            burnerAnimator.Play("Burner_Large", 0, .5f);

        }
        else
        {
            burnerAnimator.Play("Burner_Large", 0, 1f);
        }





    }
}

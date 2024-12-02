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

        burnerAnimator.speed = 0f;

    }

    // Update is called once per frame
    void Update()
    {
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

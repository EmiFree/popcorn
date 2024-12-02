using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    public string heatLevel;

    [SerializeField]
    Animator handleAnimator;





    // Start is called before the first frame update
    void Start()
    {

        handleAnimator.speed = .5f;

    }

    // Update is called once per frame
    void Update()
    {
        if (heatLevel.Equals("LOW"))
        {
            handleAnimator.speed = .2f;
        }
        else if (heatLevel.Equals("MEDIUM"))
        {
            handleAnimator.speed = 1f;

        }
        else
        {
            handleAnimator.speed = 2f;
        }





    }
}

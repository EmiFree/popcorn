using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopcornImageManager : MonoBehaviour
{
    [SerializeField]
    List<Sprite> SpriteList = new List<Sprite>();

    List<Image> ImageComponets = new List<Image>();


    public int numberOfImages = 12;

    


    public float timebetweenSwap = 2f;
    public float timerDelta = 0;
    public float timerStart = 0;
    private float timeCumulitive = 0;
    GridLayoutGroup grid;










    // Start is called before the first frame update
    void Start()
    {
        timerDelta = 0;
        timerStart = 0;
        timeCumulitive = 0;

        this.transform.parent.gameObject.AddComponent<GridLayoutGroup>();
        grid = this.GetComponentInParent<GridLayoutGroup>();
        grid.spacing = new Vector2(100, 100);

        for(int t =0; t<numberOfImages; t++)
        {
            int randomNum = Random.Range(0, SpriteList.Count);
            GameObject tempImage = new GameObject();
            ImageComponets.Add( tempImage.AddComponent<Image>());

            ImageComponets[t].sprite =  SpriteList[randomNum];

            ImageComponets[t].transform.SetParent(grid.gameObject.transform);





        }




      





    }

    // Update is called once per frame
    void Update()
    {
        timeCumulitive += Time.deltaTime;

        

        

        

        if(timeCumulitive - timerStart >= timebetweenSwap)
        {
            print("hi");
            foreach (Image i in ImageComponets)
            {
                
                i.transform.Rotate(0, 0, 90);
                i.enabled = true;
            }
            timerStart = timeCumulitive;

        }










    }
}

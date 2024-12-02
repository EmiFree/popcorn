using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoorUnlock : MonoBehaviour
{
    public GameObject door;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Collider>().enabled = true;
        GetComponent<Collider>().isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            door.SetActive(false);
            Renderer buttonRenderer = button.GetComponent<Renderer>();
            if (buttonRenderer != null)
            {
                buttonRenderer.material.color = Color.green;
            }
            else
            {
                Debug.LogError("Button to unlock door could not change colors when pressed");
            }
        }
    }
}

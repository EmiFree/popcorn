using UnityEngine;

[RequireComponent(typeof(Collider))]
public class HeatSource : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Collider>().enabled = true;
        gameObject.GetComponent<Collider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerHeatLogic component = other.gameObject.GetComponent<PlayerHeatLogic>();
            if (component != null) component.AddHeat();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerHeatLogic component = other.gameObject.GetComponent<PlayerHeatLogic>();
            if (component != null) component.ReduceHeat();
        }
    }
}

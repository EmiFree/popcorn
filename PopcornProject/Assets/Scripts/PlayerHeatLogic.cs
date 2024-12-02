using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHeatLogic : MonoBehaviour
{
    [SerializeField] private float _heatLevel = 0.0f;

    private IEnumerator _increaseHeatCoroutine;
    private IEnumerator _decreaseHeatCoroutine;

    private void Start()
    {
        _increaseHeatCoroutine = IncreaseHeat();
        _decreaseHeatCoroutine = DecreaseHeat();
    }

    private void Update()
    {
        if (_heatLevel >= 100.0f)
        {
            StopAllCoroutines();
            Pop();
            Destroy(this);
        }
    }

    // Called once. Player will begin to heat up until heatEnabled flag 
    public void AddHeat()
    {
        StopCoroutine(_decreaseHeatCoroutine);
        _decreaseHeatCoroutine = DecreaseHeat();  // reset coroutine
        StartCoroutine(_increaseHeatCoroutine);
    }

    // reduce heat level over time
    public void ReduceHeat()
    {
        StopCoroutine(_increaseHeatCoroutine);
        _increaseHeatCoroutine = IncreaseHeat();  // reset coroutine
        StartCoroutine(_decreaseHeatCoroutine);
    }

    private IEnumerator IncreaseHeat()
    {
        // increase heat until coroutine is stopped
        while (true)
        {
            // +0.3 heat / 10ms -> 100 heat in 3 seconds
            _heatLevel += 0.33f;
            yield return new WaitForSeconds(0.01f);
        }
    }

    private IEnumerator DecreaseHeat()
    {
        // small delay before beginning cooldown
        yield return new WaitForSeconds(3.0f);
        // loop until complete cool
        while (_heatLevel > 0.0f)
        {
            _heatLevel -= 5.0f;
            yield return new WaitForSeconds(0.2f);  // decrease heat level over time
        }
        _heatLevel = 0.0f;  // reset heat level
    }
    public float getHeat()
    {
        return _heatLevel;
    }
    public void setHeat(float h)
    {
        _heatLevel = h;


    }
    private void Pop()
    {
        // change model
        transform.Find("Popped").gameObject.SetActive(true);
        transform.Find("Unpopped").gameObject.SetActive(false);
        // remove player movement
        gameObject.GetComponent<ThirdPersonMovementScript>().enabled = false;
        gameObject.GetComponent<CharacterController>().enabled = false;
        // add ragdoll effect
        gameObject.AddComponent<Rigidbody>();
        gameObject.GetComponent<Rigidbody>().AddForce(500.0f * Vector3.up + 100.0f * Vector3.forward);
        // load death screen
        SceneManager.LoadSceneAsync("DeathScreen", LoadSceneMode.Additive);
        Cursor.lockState = CursorLockMode.Confined;
    }
}



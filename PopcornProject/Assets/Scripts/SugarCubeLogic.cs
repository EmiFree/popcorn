using UnityEngine;

[RequireComponent(typeof(Collider))]
public class SugarCubeLogic : MonoBehaviour
{
    private float _timer = 0.0f;
    private int _direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Collider>().enabled = true;
        GetComponent<Collider>().isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        // animate sugar cube
        float dt = Time.deltaTime;
        _timer += dt;
        transform.Translate(_direction * 0.5f * dt * Vector3.up);
        transform.Rotate(0.2f * Vector3.up);
        if (_timer > 1.0f)
        {
            _timer = 0.0f;
            _direction = _direction < 0 ? 1 : -1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<ThirdPersonMovementScript>().speed += 8.0f;
            Destroy(gameObject);
        }
    }
}

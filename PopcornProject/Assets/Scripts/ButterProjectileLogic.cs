using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class ButterProjectileLogic : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _force;

    private float _timeAlive = 0.0f;

    private void Start()
    {
        gameObject.GetComponent<SphereCollider>().enabled = true;
        gameObject.GetComponent<SphereCollider>().isTrigger = true;
    }

    void Update()
    {
        // destroy if projectile lives for too long
        if (_timeAlive > 10.0f)
        {
            Destroy(gameObject);
        }

        transform.Translate(_speed * Time.deltaTime * Vector3.forward);

        _timeAlive += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<ThirdPersonMovementScript>().Knockback(_force * transform.forward);
        }
        Destroy(gameObject);
    }
}

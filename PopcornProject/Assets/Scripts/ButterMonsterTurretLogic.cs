using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class ButterMonsterLogic : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private GameObject _projectile;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _attackDelay;

    private IEnumerator _attackCoroutine;
    private bool _isPlayerInRange = false;

    private void Start()
    {
        gameObject.GetComponent<SphereCollider>().enabled = true;
        gameObject.GetComponent<SphereCollider>().isTrigger = true;
        _attackCoroutine = Attack();
    }

    void Update()
    {
        // check if player in nearby
        if (_isPlayerInRange)
        {
            // look at player
            Vector3 direction = _player.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, _rotationSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _isPlayerInRange = true;
        StartCoroutine(_attackCoroutine);  // start attacking
    }

    private void OnTriggerExit(Collider other)
    {
        _isPlayerInRange = false;
        StopCoroutine(_attackCoroutine);  // stop attacking
        _attackCoroutine = Attack();      // reset coroutine
    }

    IEnumerator Attack()
    {
        // loop while player is nearby
        while (_isPlayerInRange)
        {
            yield return new WaitForSeconds(_attackDelay);  // delay next attack
            _projectile.transform.position = transform.position;
            _projectile.transform.rotation = transform.rotation;
            Instantiate(_projectile);
        }
    }
}

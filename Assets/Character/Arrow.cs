using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    bool _isMoving = true;
    bool _hitSomething = false;
    float lifeTime = 8f;
    // Serialized Values
    [SerializeField] float _flightSpeed = 0.1f;

    void Start()
    {
        Destroy(gameObject,5);    
    }


    void Update()
    {
        if (_isMoving)
            transform.position += transform.forward * _flightSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.name == "BaseRing")
        {
            Stop();
        }
    }

    public void Stop()
    {
        _isMoving = false;
        SphereCollider thisBody = GetComponent<SphereCollider>();
        thisBody.enabled = false;
    }

}

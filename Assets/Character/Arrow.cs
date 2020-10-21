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

    // Update is called once per frame
    void Update()
    {
        if (_isMoving)
            transform.position += transform.forward * _flightSpeed * Time.deltaTime;
        
        lifeTime -= 1f * Time.deltaTime;
        //Debug.Log(lifeTime);
        if (lifeTime < 0)
            Destroy(this);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.name != "Body" && other.name != "Player") {
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

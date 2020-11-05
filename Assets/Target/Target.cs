using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    [SerializeField] RuntimeData _runtimeData;

    [SerializeField] float _sightDistance = 20f; 
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (_runtimeData._isAggro && distance < (_runtimeData.isDay ? _sightDistance : (2 * _sightDistance / 5))) {
            transform.LookAt(player.transform);
            transform.RotateAround(transform.position, new Vector3(0,1,0), -90f);
            float speed = (_runtimeData.isDay) ? 2f : 4f;
            float boost = _runtimeData.day / 4; 
            transform.position += transform.right * (speed + boost) * Time.deltaTime;
        }
    }
}

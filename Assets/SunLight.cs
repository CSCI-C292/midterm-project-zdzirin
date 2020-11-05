using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunLight : MonoBehaviour
{
    [SerializeField] int _speed = 20;
    [SerializeField] float _fallSpeed = 0.001f;
    [SerializeField] RuntimeData _runtimeData;
    // Update is called once per frame
    void Update()
    {
      // Rotate once the game has began
      if (_runtimeData.day > 0) {
        transform.RotateAround(Vector3.zero, new Vector3(1, 0, 0), _speed * Time.deltaTime);
        //float step = _fallSpeed * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, step);
      } 
          
      // Determines wether it is day or night
      if (transform.position.y < 0) {
        _runtimeData.isDay = false;
      } else {
        _runtimeData.isDay = true;
      }
        
    }
}

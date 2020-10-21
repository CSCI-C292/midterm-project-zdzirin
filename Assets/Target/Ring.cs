using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{

    [SerializeField] int value;
    [SerializeField] RuntimeData _runtimeData;

    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log(this.name);
        if (other.name == "Arrow(Clone)")
        {
            Debug.Log(value);
            _runtimeData.currentScore += value;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightLight : MonoBehaviour
{
    [SerializeField] RuntimeData _runtimeData;
    void Update()
    {
        if (_runtimeData.isDay) {
            GetComponent<Light>().enabled = false;
        } else {
            GetComponent<Light>().enabled = true;
        }
    }
}

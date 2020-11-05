using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayAdvancer : MonoBehaviour
{
    [SerializeField] RuntimeData _runtimeData;
    
    private void OnTriggerEnter(Collider other) {
        if (other.name == "Sphere") {
            _runtimeData.day++;
            _runtimeData.totalScore += _runtimeData.currentScore;
            _runtimeData.currentScore = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{

    [SerializeField] RuntimeData _runtimeData;

    void Awake() {
        _runtimeData.totalScore = 0;
        _runtimeData.currentScore = 0;
        _runtimeData.day = 0;
        _runtimeData.isDay = true;
        _runtimeData._isAggro = false;
    }


}

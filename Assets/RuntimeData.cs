using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New RuntimeData")]

public class RuntimeData : ScriptableObject
{
    public int totalScore = 0;
    public int currentScore = 0;
    public bool isDay = true;
    public bool _isAggro = false;
    public int day = 0;

}

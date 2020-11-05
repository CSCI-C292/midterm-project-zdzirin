using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ring : MonoBehaviour
{

    [SerializeField] int value;
    [SerializeField] RuntimeData _runtimeData;
    [SerializeField] GameObject _runText;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.name == "Arrow(Clone)")
        {
            _runtimeData.currentScore += 1;
            if (!_runtimeData._isAggro && _runtimeData.currentScore > 10)
            {
                _runtimeData._isAggro = true;
                _runtimeData.day++;
                Instantiate(_runText);
            }
        } else if (other.name == "Player") {
            SceneManager.LoadScene(2);
        }
    }

    void Update() 
    {
        
    }



}

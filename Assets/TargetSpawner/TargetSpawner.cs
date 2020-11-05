using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField] GameObject _targetPrefab;
    GameObject _lightComponent;
    bool _hasSpawned = false;
    public bool getHasSpawned() { return _hasSpawned; }
    
    public void SpawnTarget() {
        Debug.Log("Spawning at spawner: " + gameObject.name);
        Instantiate(_targetPrefab,transform.position,Quaternion.identity);
        _hasSpawned = true;
    }
    void Start() {
        _lightComponent = transform.Find("SpawnerLight").gameObject;
        _lightComponent.SetActive(false);
    }

    void Update() {
        if (_hasSpawned && _lightComponent.activeSelf == false) {        
            _lightComponent.SetActive(true);
        } else {
            _lightComponent.SetActive(false);
        }
    }

}

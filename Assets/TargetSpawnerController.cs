using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawnerController : MonoBehaviour
{
    [SerializeField] List<GameObject> _targetSpawnerList;
    [SerializeField] RuntimeData _runtimeData;
    private int _internalDay = 0;
    // Update is called once per frame
    void Update()
    {
        if (_runtimeData.day != _internalDay && _runtimeData.day < _targetSpawnerList.Count){
            _internalDay = _runtimeData.day;
            Spawn();    
        }
    }

    void Spawn() {
        bool spawned = false;
        while (!spawned) {
            int n = Random.Range(0,_targetSpawnerList.Count);
            TargetSpawner spawner = _targetSpawnerList[n].GetComponent<TargetSpawner>();
            if (!spawner.getHasSpawned()) {
                spawner.SpawnTarget();
                spawned = true;
            }
        }
    }
}

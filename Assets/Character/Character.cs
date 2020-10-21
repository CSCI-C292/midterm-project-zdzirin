using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    [SerializeField] GameObject _arrowPrefab;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();        
    }

    void Shoot() 
    {
        if (Input.GetMouseButtonDown(0)) {
            Transform startPos = transform;
            startPos.position += Vector3.forward * 0.25f;
            Instantiate(_arrowPrefab, startPos);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] private GameObject enemy;

    private float xLimit = 16f;

    void Start()
    {

        Instantiate(enemy,
            SpawnPos(),
            Quaternion.identity);

    }

    void Update()
    {
        
    }

    private Vector3 SpawnPos()
    {
        float x = Random.Range(-xLimit, xLimit);

        return new Vector3(x, 0, 22);
    }

}

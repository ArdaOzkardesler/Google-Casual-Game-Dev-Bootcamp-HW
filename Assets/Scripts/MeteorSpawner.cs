using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject[] _spawnPoints;
    public GameObject _selectedSpawnPoint;
    [SerializeField] GameObject meteor;


    private void Awake() {
        _spawnPoints=GameObject.FindGameObjectsWithTag("MeteorSpawnPoint"); //store the spawn points in the array
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            _selectedSpawnPoint=_spawnPoints[Random.Range(0,_spawnPoints.Length)]; // select a random spawn point from the array
            Instantiate(meteor, _selectedSpawnPoint.transform.position, Quaternion.identity); //instantiate a meteor at the selected spawn point
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject[] _spawnPoints;
    public GameObject _selectedSpawnPoint;
    [SerializeField] GameObject meteor;


    private void Awake() {
        _spawnPoints=GameObject.FindGameObjectsWithTag("MeteorSpawnPoint");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            _selectedSpawnPoint=_spawnPoints[Random.Range(0,_spawnPoints.Length)];
            Instantiate(meteor, _selectedSpawnPoint.transform.position, Quaternion.identity);
        }
    }
}

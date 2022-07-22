using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorScript : MonoBehaviour
{
    public GameObject[] _planets;
    // public GameObject[] _spawnPoints;
    public GameObject _selectedPlanet;
    // public GameObject _selectedSpawnPoint;
    [SerializeField] float speed=40f;
    // [SerializeField] GameObject meteor;
    [SerializeField] GameObject explosion;
    

    private void Awake() {
        _planets=GameObject.FindGameObjectsWithTag("TrackingObject");
        // _spawnPoints=GameObject.FindGameObjectsWithTag("MeteorSpawnPoint");
    }
    void Start()
    {
        _selectedPlanet=_planets[Random.Range(0,_planets.Length)];
        // explosion=gameObject.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(_selectedPlanet.transform);
        transform.position = Vector3.MoveTowards(transform.position, _selectedPlanet.transform.position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag=="TrackingObject")
        {
            Instantiate(explosion,other.contacts[0].point,Quaternion.identity);
            Destroy(gameObject);
            
        }
    }
}

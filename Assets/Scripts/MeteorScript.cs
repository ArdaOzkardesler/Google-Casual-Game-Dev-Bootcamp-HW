using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorScript : MonoBehaviour
{
    public GameObject[] _planets;
    public GameObject _selectedPlanet;
    [SerializeField] float speed=40f;
    [SerializeField] GameObject explosion;
    

    private void Awake() {
        _planets=GameObject.FindGameObjectsWithTag("TrackingObject"); //store the planets in the array
    }
    void Start()
    {
        _selectedPlanet=_planets[Random.Range(0,_planets.Length)]; //select a random planet from the array
    }

    void Update()
    {
        transform.LookAt(_selectedPlanet.transform);
        transform.position = Vector3.MoveTowards(transform.position, _selectedPlanet.transform.position, speed * Time.deltaTime); //make the asteroid move towards the selected planet at a certain speed
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag=="TrackingObject")
        {
            Instantiate(explosion,other.contacts[0].point,Quaternion.identity); //play the explosion particle system on collision
            Destroy(gameObject);
            
        }
    }
}

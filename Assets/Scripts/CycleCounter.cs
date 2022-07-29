using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleCounter : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    private float _distance;
    private int _cycle=0;

    private void Start() {
        rotationSpeed=transform.parent.gameObject.GetComponent<CelestialMovement>().RotationSpeed;
    }
    
    void Update()
    {
        _distance+=rotationSpeed*Time.deltaTime; // calculate the distance traveled by the planet on the orbit

        if (_distance>360)
        {
            _distance=0;
            _cycle++;
            Debug.Log(gameObject.name + " has completed a full rotation! Cycle: "+_cycle); // log a message to the console whenever a planet completes a full rotation around the Sun
        }
    }
}

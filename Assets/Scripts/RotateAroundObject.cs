using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundObject : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float rotationSpeed;
    private float _distance;
    private int _cycle=0;


    void Start()
    {
        StartCoroutine(Rotate());
    }

    IEnumerator Rotate(){
        transform.RotateAround(target.transform.position,Vector3.up,rotationSpeed*Time.deltaTime); // make the planet rotate around a target GameObject
        _distance+=rotationSpeed*Time.deltaTime; // calculate the distance traveled by the planet on the orbit

        if (_distance>360)
        {
            _distance=0;
            _cycle++;
            Debug.Log(gameObject.name + " has completed a full rotation! Cycle: "+_cycle); // log a message to the console whenever a planet completes a full rotation around the Sun
        }
        yield return new WaitForEndOfFrame();
        StartCoroutine(Rotate());
    }
}

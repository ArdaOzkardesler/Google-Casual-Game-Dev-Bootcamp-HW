using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundSelf : MonoBehaviour
{
    [SerializeField] float rotationSpeed;

    void Update(){
        transform.RotateAround(transform.position, Vector3.up, rotationSpeed * Time.deltaTime); // make the GameObject rotate around itself
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelestialMovement : MonoBehaviour
{
    public Transform TargetObject;
    public float RotationSpeed;

    private void Update() {
        if (TargetObject==null)
        {
            return;
        }
        transform.RotateAround(TargetObject.position,Vector3.up,Time.deltaTime*RotationSpeed);
    }
}

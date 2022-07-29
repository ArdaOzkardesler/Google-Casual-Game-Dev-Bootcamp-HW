using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Moon", menuName = "Scriptable Objects/Moon SO", order = 1)]

public class MoonDataSO : CelestialDataSO
{
    [SerializeField] GameObject _moonPrefab;
    [SerializeField] float _orbitRadius;

    private Transform _parentPlanet;
    private GameObject moon;

    public void InstantiateMoon(CelestialDataHandler celestialDataHandler){
         moon = Instantiate(_moonPrefab);
        _parentPlanet=celestialDataHandler.gameObject.transform;
    }

    private void Update() {
        if (_parentPlanet!=null)
        {
            moon.transform.RotateAround(_parentPlanet.transform.position,Vector3.up,Time.deltaTime*_orbitRadius);
        }
    }

    public override void InitializeCelestial(CelestialDataHandler celestialDataHandler){
        throw new System.NotImplementedException();
    }

}

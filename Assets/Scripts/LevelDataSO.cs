using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "Scriptable Objects/Level Data", order = 1)]

public class LevelDataSO : ScriptableObject
{
    public StarDataSO Star;
    public List<PlanetData> Planets;

}

[System.Serializable]
public class PlanetData{
    public PlanetDataSO Planet;
    public float DistanceToStar;
    public List<MoonData> Moons;
}

[System.Serializable]
public class MoonData{
    public MoonDataSO Moon;
    public float DistanceToPlanet;
}

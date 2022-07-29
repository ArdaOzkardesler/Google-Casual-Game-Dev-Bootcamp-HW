using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInitializer : MonoBehaviour
{
    [SerializeField] LevelDataSO levelData;
    GameObject _star;

    public float Radius;
    public float Tetha;


    void Start()
    {
        _star=Instantiate(levelData.Star.CelestialPrefab,Vector3.zero,Quaternion.identity);

        foreach (var planet in levelData.Planets)
        {
            float randomTetha=Random.Range(0f,360f);
            Vector3 randomOrbitPosition = _star.transform.position+GetRandomPositionOnOrbit(randomTetha,planet.DistanceToStar);
            var planetObject=Instantiate(planet.Planet.CelestialPrefab,randomOrbitPosition,Quaternion.identity);
            if (planetObject.GetComponent<CelestialMovement>()!=null)
            {
                planetObject.GetComponent<CelestialMovement>().TargetObject=_star.transform;
            }

            foreach (var moon in planet.Moons)
            {
                randomTetha=Random.Range(0f,360f);
                randomOrbitPosition = planetObject.transform.position+GetRandomPositionOnOrbit(randomTetha,moon.DistanceToPlanet);
                var moonObject=Instantiate(moon.Moon.CelestialPrefab,randomOrbitPosition,Quaternion.identity);
                moonObject.transform.parent=planetObject.transform;
                if (moonObject.GetComponent<CelestialMovement>()!=null)
            {
                moonObject.GetComponent<CelestialMovement>().TargetObject=planetObject.transform;
            }
            }
            // planetObject.transform.parent=_star.transform;
            // planetObject.transform.localPosition=new Vector3(planet.DistanceToStar,0,0);
        }
    }


    private static Vector3 GetRandomPositionOnOrbit(float tetha,float radius){
        return new Vector3(Mathf.Cos(tetha*Mathf.Deg2Rad)*radius,0,Mathf.Sin(tetha*Mathf.Deg2Rad)*radius);
    }

[ContextMenu("GetAxis")]
    public void GetAxis(){
        float x=Mathf.Cos(Tetha*Mathf.Deg2Rad)*Radius;
        float z=Mathf.Sin(Tetha*Mathf.Deg2Rad)*Radius;
        Debug.Log("x:"+x+"z:"+z);
    }
}

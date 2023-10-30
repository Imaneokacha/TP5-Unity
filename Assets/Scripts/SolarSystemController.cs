using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SolarSystemController : MonoBehaviour
{
    // Start is called before the first frame update
    public enum Planet { Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune }
    public GameObject mercury;
    public GameObject venus;
    public GameObject earth;
    public GameObject mars;
    public GameObject jupiter;
    public GameObject saturn;
    public GameObject uranus;
    public GameObject neptune;
    void Start()
    {
        PlanetManager.current.OnTimeChange += UpdatePosition;
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void UpdatePosition(DateTime t){
        foreach (PlanetData.Planet p in Enum.GetValues(typeof(Planet))){
            Vector3 vector = PlanetData.GetPlanetPosition(p, t);
            SetPlanetPosition(p, vector);

        }
    void SetPlanetPosition(PlanetData.Planet planet, Vector3 position)
    {
        GameObject planetSphere = GetGameObject(planet);
        
        planetSphere.transform.position = position;
        
    }

    }
    GameObject GetGameObject(PlanetData.Planet planet)
    {
        switch (planet)
        {
            case PlanetData.Planet.Mercury: return mercury;
            case PlanetData.Planet.Venus: return venus;
            case PlanetData.Planet.Earth: return earth;
            case PlanetData.Planet.Mars: return mars;
            case PlanetData.Planet.Jupiter: return jupiter;
            case PlanetData.Planet.Saturn: return saturn;
            case PlanetData.Planet.Uranus: return uranus;
            case PlanetData.Planet.Neptune: return neptune;
        }
        return null;
    }
   
}

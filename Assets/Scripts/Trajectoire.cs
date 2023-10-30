using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trajectoire : MonoBehaviour
{
    public List<LineRenderer> trajectoryLineRenderers;
    public int positionsCount = 1000;
    public float lineWidth = 0.1f;
    public Color lineColor = Color.white;
    public List<PlanetData.Planet> planets;
    private List<Vector3[]> positionsList;
    public Toggle toggle;

    void Start()
    {
        InitializeLineRenderers();
    }

    public void InitializeLineRenderers()
    {
        positionsList = new List<Vector3[]>();

        for (int i = 0; i < trajectoryLineRenderers.Count; i++)
        {
            trajectoryLineRenderers[i].positionCount = positionsCount;
            trajectoryLineRenderers[i].startWidth = lineWidth;
            trajectoryLineRenderers[i].endWidth = lineWidth;
            trajectoryLineRenderers[i].startColor = lineColor;
            trajectoryLineRenderers[i].endColor = lineColor;

            positionsList.Add(new Vector3[positionsCount]);
        }
    }

    public void ShowTrajectories()
    {
        if (toggle != null)
        {
            for (int i = 0; i < trajectoryLineRenderers.Count; i++)
            {
                UDateTime currentDate = PlanetManager.current.Date;

                for (int j = 0; j < positionsCount; j++)
                {
                    Vector3 planetPosition = PlanetData.GetPlanetPosition(planets[i], currentDate.dateTime.AddDays(j));

                    positionsList[i][j] = planetPosition;
                }

                if (toggle.isOn)
                {
                    trajectoryLineRenderers[i].SetPositions(positionsList[i]);
                }
                else
                {
                    Vector3[] emptyArray = new Vector3[positionsCount];
                    trajectoryLineRenderers[i].SetPositions(emptyArray);
                }
            }
        }
    }
}

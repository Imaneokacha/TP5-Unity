using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedChange : MonoBehaviour
{
    public Slider timeSpeedSlider; 
    public PlanetManager planetManager; 


    private void Start()
    {
        timeSpeedSlider.value = 0.0f;
    }

    public void ChangeSpeed()
    {
        float timeScale = timeSpeedSlider.value;
        UDateTime currentDate = planetManager.Date;


        planetManager.Date = currentDate.dateTime.AddDays(timeScale);

    }
}

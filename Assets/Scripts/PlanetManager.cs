using UnityEngine;
using System;
public class PlanetManager :  MonoBehaviour
{

    public static PlanetManager current;
    public UDateTime date;
    public UDateTime Date{
        get => date;
        set
        {
            date = value;
            current.TimeChanged(value.dateTime); 
    }
     
    }
    private void Awake()
    {
        if (current == null)
            {
            current = this;
            }
        else
        {
            Destroy(obj: this);
        }
    }   
    public event Action<DateTime> OnTimeChange;

    public void TimeChanged(DateTime newTime)
    {
        OnTimeChange?.Invoke(newTime);
    }
void Update(){
    Date = date.dateTime.AddDays(1.0);
}
}
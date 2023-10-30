using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeScale : MonoBehaviour
{
    public Transform Earth;
    public Transform Mars;
    public Transform Venus;
    public Transform Mercury;
    public Transform Jupiter;
    public Transform Saturn;
    public Transform Uranus;
    public Transform Neptune;    
    public float newScale = 10.0f;
    void Start()
    {
        
    }

    public void Changescale()
    {
        Earth.localScale = new Vector3(newScale, newScale, newScale);
        Mars.localScale = new Vector3(newScale, newScale, newScale);
        Venus.localScale = new Vector3(newScale, newScale, newScale);
        Mercury.localScale = new Vector3(newScale, newScale, newScale);
        Jupiter.localScale = new Vector3(newScale, newScale, newScale);
        Saturn.localScale = new Vector3(newScale, newScale, newScale);
        Uranus.localScale = new Vector3(newScale, newScale, newScale);
        Neptune.localScale = new Vector3(newScale, newScale, newScale);
    
    }
}

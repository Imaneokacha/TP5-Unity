using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CenterCameraOnPlanet : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // Vérifie si le bouton droit de la souris est cliqué
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
               mainCamera.transform.position = new Vector3(hit.transform.position.x,hit.transform.position.y,hit.transform.position.z-1);
            
            }
        }
    }

}
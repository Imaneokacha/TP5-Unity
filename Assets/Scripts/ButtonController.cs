using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonController : MonoBehaviour
{
    public InputField dateInputField;

    private void Start()
    {
        dateInputField.onValueChanged.AddListener(OnDateInputValueChanged);
    }

    public void OnDateInputValueChanged(string newDate)
    {
        //convertir la chaîne en DateTime
        if (DateTime.TryParse(newDate, out DateTime parsedDate))
        {
            PlanetManager.current.Date = parsedDate;
        }
        else
        {
            // le cas où la saisie n'est pas une date valide
            Debug.LogWarning("Date invalide : " + newDate);
        }
    }
}

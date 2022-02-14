using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedUI : MonoBehaviour
{
    public Text speedText;
    private Vehicle vehicleInstance;

    void Update()
    {
        if (GetComponent<Vehicle>() != null && vehicleInstance == null)
        {
            vehicleInstance = FindObjectsOfType<Vehicle>()[0];
            return;
        }
        speedText.text = vehicleInstance != null ? Math.Round(vehicleInstance.speed, 2).ToString() : "";
    }
}

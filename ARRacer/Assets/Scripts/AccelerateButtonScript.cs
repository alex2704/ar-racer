using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccelerateButtonScript : MonoBehaviour
{
    private ProgramManager ProgramManagerScript;
    public Button AccelerateButton;

    private bool Forward = false;

    // Start is called before the first frame update
    void Start()
    {
        ProgramManagerScript = FindObjectOfType<ProgramManager>();
        AccelerateButton.onClick.AddListener(() => Accelerate());
    }

    void Accelerate()
    {
        Forward = true;

        if (ProgramManagerScript.IsVehicleVisible)
        {
            //var vec = new Vector3(0,0,7.0f);
            //ProgramManagerScript.Vehicle.transform.position += vec;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

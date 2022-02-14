using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool IsPressed = false;
    public GameObject Vehicle;
    private ProgramManager ProgramManagerScript;

    void Start()
    {
        ProgramManagerScript = FindObjectOfType<ProgramManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ProgramManagerScript.Vehicle != null)
        {
            Vehicle = ProgramManagerScript.Vehicle;
        }

        if (IsPressed)
        {
            Debug.Log("x=" + Vehicle.transform.position.x);
            Debug.Log("y=" + Vehicle.transform.position.y);
            Debug.Log("z=" + Vehicle.transform.position.z);
            Vehicle.transform.Translate(0f, 0f, 0.1f);
        }
    }

    public void OnPointerDown(PointerEventData data) 
    {
        IsPressed = true;
    }

    public void OnPointerUp(PointerEventData data) 
    {
        IsPressed = false;
    }
}

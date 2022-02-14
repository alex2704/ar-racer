using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftRightButtons : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Direction direction;
    public GameObject vehicle;
    public ProgramManager programManager;
    bool isPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(programManager.Vehicle != null && vehicle == null)
        {
            vehicle = programManager.Vehicle;
        }

        if(isPressed)
        {
            switch (direction)
            {
                case Direction.Left:
                    vehicle.transform.Rotate(0f, -0.5f, 0f, Space.World);
                    break;
                case Direction.Right:
                    //vehicle.transform.Translate(new Vector3(0.5f, 0f, 0.5f) * Time.deltaTime, Space.World);
                    vehicle.transform.Rotate(0f, 0.5f, 0f, Space.World);
                    break;
                case Direction.Forward:
                    vehicle.transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
                    break;
                case Direction.Back:
                    vehicle.transform.Translate(Vector3.back * Time.deltaTime, Space.World);
                    break;
                default:
                    break;
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}

public enum Direction
{
    Left,
    Right,
    Forward,
    Back
}
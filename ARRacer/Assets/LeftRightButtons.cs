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
    public Vehicle vehicleInstance;

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
        if(GetComponent<Vehicle>() != null || vehicleInstance == null)
        {
            vehicleInstance = FindObjectsOfType<Vehicle>()[0];
            return;
        }

        if (isPressed)
        {
            switch (direction)
            {
                case Direction.Left:
                    vehicleInstance.direction = vehicleInstance.direction - new Vector3(vehicleInstance.direction.x, vehicleInstance.direction.y + 1.0f, vehicleInstance.direction.z) * Time.deltaTime;
                    break;
                case Direction.Right:
                    vehicleInstance.direction = vehicleInstance.direction + new Vector3(vehicleInstance.direction.x, vehicleInstance.direction.y + 1.0f, vehicleInstance.direction.z) * Time.deltaTime;
                    break;
                case Direction.Forward:
                    vehicleInstance.speed = vehicleInstance.speed + (vehicleInstance.accelerate * Time.deltaTime);
                    break;
                case Direction.Back:
                    vehicleInstance.speed = vehicleInstance.speed - (vehicleInstance.accelerate * Time.deltaTime) * 0.5f;
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
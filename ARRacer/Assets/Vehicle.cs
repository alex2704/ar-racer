using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public float speed;
    public Vector3 direction;

    public void ChangeSpeed(float value)
    {
        speed = +value;
    }

    //public void ChangeDirection(float value)
    //{
    //    direction;
    //}
}

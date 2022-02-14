using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public float speed = 0f;
    public float maxSpeed = 10f;
    public float minSpeed = 0f;
    public float accelerate = 10f;

    public float maxAngle = 5f;

    public Vector3 direction = new Vector3(0f, 3f, 0f);

    public void Update()
    {
        if (speed > minSpeed)
        {
            var delta = Time.deltaTime;
            speed = +speed - delta < 0 ? 0 : speed - delta;
        }

        if (speed < minSpeed)
        {
            var delta = Time.deltaTime;
            speed = +speed + delta > 0 ? 0 : speed + delta;
        }

        if (speed >= maxSpeed)
            speed = maxSpeed;

        if (-speed >= maxSpeed)
            speed = -maxSpeed;

        if (direction.y >= maxAngle)
            direction.y = maxAngle;

        if (-direction.y >= maxAngle)
            direction.y = -maxAngle;

        float myDirection = transform.eulerAngles.y;
        Vector3 vectorDirection = Quaternion.Euler(0, myDirection, 0) * Vector3.forward * speed;
        transform.Translate(vectorDirection * Time.deltaTime, Space.World);
        if(speed != 0)
            transform.Rotate(direction, Space.World);
    }
}

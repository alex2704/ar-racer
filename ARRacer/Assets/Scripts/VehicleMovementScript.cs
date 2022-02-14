using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovementScript : MonoBehaviour
{
    //public GameObject Vehicle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveForward()
    {
        var vec = new Vector3(0, 0, 3.0f);
        this.transform.position += vec;
    }
}

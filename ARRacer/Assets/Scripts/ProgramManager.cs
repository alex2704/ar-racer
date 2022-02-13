using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ProgramManager : MonoBehaviour
{
    public GameObject PlaneMarkerPrefab;
    public GameObject Vehicle;
    private ARRaycastManager ARRaycastManagerScript;
    private Vector2 TouchPosition;

    // Start is called before the first frame update
    void Start()
    {
        ARRaycastManagerScript = FindObjectOfType<ARRaycastManager>();

        PlaneMarkerPrefab.SetActive(false);
        //Vehicle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] vehicles = GameObject.FindGameObjectsWithTag("Vehicle");

        if (vehicles.Length < 1)
        {
            ShowMarker();
        }
        //if (!Vehicle.activeSelf)
        //{
        //    ShowMarker();
        //}
    }

    void ShowMarker()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();

        ARRaycastManagerScript.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);

        if (hits.Count > 0)
        {
            PlaneMarkerPrefab.transform.position = hits[0].pose.position;
            PlaneMarkerPrefab.SetActive(true);
        }

        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Instantiate(Vehicle, hits[0].pose.position, Vehicle.transform.rotation);
            //Vehicle.SetActive(true);
        }
    }
}

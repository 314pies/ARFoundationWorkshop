using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class ARRayCastTest : MonoBehaviour
{
    [SerializeField]
    ARRaycastManager m_RaycastManager;
    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    List<ARRaycastHit> m_Hits = new List<ARRaycastHit>();

    public GameObject cube;
    // Update is called once per frame
    void Update()
    {
        var raycastPoint = Camera.main.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        if (m_RaycastManager.Raycast(raycastPoint, hits, TrackableType.PlaneWithinPolygon))
        {
            var hitPose = hits[0].pose;
            cube.transform.position = hitPose.position;

            //var cameraForward = Camera.main.transform.forward;
            //var cameraBearing = new Vector3(cameraForward.x, 0, cameraForward.z).normalized;
            //cube.transform.rotation = Quaternion.LookRotation(cameraBearing);
        }
    }
}

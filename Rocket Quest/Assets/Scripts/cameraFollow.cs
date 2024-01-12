using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public float minZoom = 5f;
    public float maxZoom = 15f;
    public float zoomSpeed = 5f;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private Camera cam;
    private RaycastHit groundHit;

    void Start()
    {
        cam = Camera.main;
    }

    void LateUpdate()
    {

        float distance = Vector3.Distance(transform.position, target.position);

        if (Physics.Raycast(target.position, Vector3.down, out groundHit))
        {
            float targetHeight = groundHit.point.y + offset.y;
            offset.y = Mathf.Lerp(offset.y, targetHeight - target.position.y, smoothSpeed * Time.deltaTime);
        }

        float desiredZoom = Mathf.Clamp(distance, minZoom, maxZoom);
        float smoothZoom = Mathf.Lerp(cam.orthographicSize, desiredZoom, zoomSpeed * Time.deltaTime);

        Vector3 desiredPosition = target.position + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        cam.orthographicSize = smoothZoom;
    }
}


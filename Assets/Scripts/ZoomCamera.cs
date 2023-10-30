using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    public float zoomSpeed = 5.0f;
    public float minZoom = 10.0f;
    public float maxZoom = 60.0f;

    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        float zoomInput = Input.GetAxis("Mouse ScrollWheel");

        ZoomCam(zoomInput);
    }

    private void ZoomCam(float zoomInput)
    {
        float newFieldOfView = mainCamera.fieldOfView - zoomInput * zoomSpeed;

        newFieldOfView = Mathf.Clamp(newFieldOfView, minZoom, maxZoom);

        mainCamera.fieldOfView = newFieldOfView;
    }
}

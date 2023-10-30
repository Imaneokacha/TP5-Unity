using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public Transform target; // L'objet autour duquel s'effectue la rotation
    public float rotationSpeed = 1.0f;

    private Vector3 previousMousePosition;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            previousMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 currentMousePosition = Input.mousePosition;
            Vector3 direction = previousMousePosition - currentMousePosition;

            RotateCameraAroundTarget(direction);
            previousMousePosition = currentMousePosition;
        }
    }

    private void RotateCameraAroundTarget(Vector3 direction)
    {
        float horizontalInput = direction.x * rotationSpeed;

        transform.RotateAround(target.position, Vector3.up, horizontalInput);
    }
}

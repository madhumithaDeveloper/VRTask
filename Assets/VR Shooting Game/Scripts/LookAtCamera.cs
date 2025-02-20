using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public Camera cam;
    public Transform canvasTransform;
    Vector3 lookAtPos;


    void Update()
    {
        LookAtCameraTransform();
    }


    void LookAtCameraTransform()
    {
        lookAtPos = cam.transform.position;
        lookAtPos.y = canvasTransform.position.y;

        canvasTransform.LookAt(lookAtPos);
    }
}

using Unity.VisualScripting;
using UnityEngine;

public class UIFollowCamera : MonoBehaviour
{
    public Camera cam;
    public GameObject objectToFollow;// object should be placed as the child of the camera to follow
    public Transform objectToMove;
    public float dist;
    public float speed;


    void Update()
    {
        Vector3 temp = objectToFollow.transform.localPosition;

        objectToFollow.transform.localPosition = new Vector3(0, temp.y, dist);

        objectToMove.transform.position = Vector3.Lerp(objectToMove.transform.position, objectToFollow.transform.position, speed);
    }


    public void SetCanvasPosition()
    {
        objectToMove.position = objectToFollow.transform.position;    
    }
}

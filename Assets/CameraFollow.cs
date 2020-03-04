
using UnityEngine;

//smoothSpeed: the laginess of the camera behind the cube
    // 0 < x < 1
    // as x approached 1, the closer it follows the cube, until it is directly mimicking
    //the cube's movements




public class CameraFollow : MonoBehaviour{

    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;


    void LateUpdate()
    {

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

    }



}

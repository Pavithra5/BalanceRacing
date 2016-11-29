using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public Transform target;
    private Vector3 updatedPosition;
    void FixedUpdate()
    {
        updatedPosition = target.position;
        updatedPosition.z = -10;
        transform.position = updatedPosition;
    }
}

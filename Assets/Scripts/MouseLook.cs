using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
   float xRotation = 0f;
    public Vector2 turn;
    public float sensitivity = 50;
    public Vector3 deltaMove;
    public float speed = 1;
    public Transform playerBody;



    // public Transform target;
    // public float smoothTime = 0.3F;
    // private Vector3 velocity = Vector3.zero;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        turn.x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        turn.y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        playerBody.Rotate(Vector3.up * turn.x);
        xRotation -= turn.y;
        xRotation = Mathf.Clamp(xRotation, -30f, 70f);
        transform.localRotation = Quaternion.Euler(xRotation, 180, 0);

        // // Define a target position above and behind the target transform
        // Vector3 targetPosition = target.TransformPoint(new Vector3(0, 0, 0));
        // // Smoothly move the camera towards that target position
        // transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
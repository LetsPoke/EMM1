using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    //public Transform target;
    private Vector3 offset;
    public float zoomSpeed = 4f;
    public float minZoom = 1f;
    public float maxZoom = 3f;
    private float currentZoom = 1f;

    private void Start()
    {
        offset = transform.position - player.transform.position;
    }

     void Update() {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
    }

    private void LateUpdate()
    {

        transform.position = player.transform.position + ((Quaternion.Slerp(player.transform.rotation, transform.rotation,2))*offset) * currentZoom/10; //* currentZoom

        transform.rotation = player.transform.rotation * Quaternion.Euler(20, 0, 0);
        
    }
}

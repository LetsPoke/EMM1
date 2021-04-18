using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    //public Transform target;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - player.transform.position;
    }

    private void LateUpdate()
    {

        transform.position = player.transform.position + ((Quaternion.Slerp(player.transform.rotation, transform.rotation,2))*offset);

        transform.rotation = player.transform.rotation * Quaternion.Euler(20, 0, 0);
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float smooth;
    private float difX, difZ;
    void Start()
    {
        difX = player.transform.position.x - transform.position.x;
        difZ = player.transform.position.z - transform.position.z;
    }
    void FixedUpdate()
    {
        float playerX = player.transform.position.x;
        float playerZ = player.transform.position.z;
        float smoothX = Mathf.Lerp(transform.position.x, playerX - difX, smooth * Time.fixedDeltaTime);
        float smoothZ = Mathf.Lerp(transform.position.z, playerZ - difZ, smooth * Time.fixedDeltaTime);
        transform.position = new Vector3(smoothX, transform.position.y, smoothZ);
    }
}

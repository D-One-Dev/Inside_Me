using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    private PlayerInput pi;

    private void Awake()
    {pi = new PlayerInput();}
    private void OnEnable()
    { pi.Enable(); }
    private void OnDisable()
    { pi.Disable(); }
    void Start()
    {
    }
    void FixedUpdate()
    {
        float moveX = pi.Gameplay.MoveX.ReadValue<float>();
        float moveZ = pi.Gameplay.MoveZ.ReadValue<float>();
        float rotateY = pi.Gameplay.RotateX.ReadValue<float>();
        rb.velocity = new Vector3(moveX * speed, rb.velocity.y, moveZ * speed);
        transform.Rotate(0f, rotateY * speed, 0f);
    }
}

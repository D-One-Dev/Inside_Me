using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed, reloadTime;
    [SerializeField] private Transform bullet, bulletSpawn;
    private PlayerInput pi;
    private float timer;
    private bool fireStart;

    private void Awake()
    {
        //Gamepad input
        pi = new PlayerInput();
        pi.Gameplay.Fire.performed += context => fireStart = true;
        pi.Gameplay.Fire.canceled += context => fireStart = false;
    }
    private void OnEnable()
    { pi.Enable(); }
    private void OnDisable()
    { pi.Disable(); }
    void Start()
    {
    }
    void FixedUpdate()
    {
        //Reload timer
        if (timer >= 0) timer -= Time.fixedDeltaTime;
        //Moving and rotating
        float moveX = pi.Gameplay.MoveX.ReadValue<float>();
        float moveZ = pi.Gameplay.MoveZ.ReadValue<float>();
        float rotateY = pi.Gameplay.RotateX.ReadValue<float>();
        rb.velocity = new Vector3(moveX * speed, rb.velocity.y, moveZ * speed);
        transform.Rotate(0f, rotateY * speed, 0f);
        //Fire
        if (fireStart && timer < 0) Fire();
    }

    private void Fire()
    {
        //Refreshing the timer
        timer = reloadTime;
        //Creating the bullet
        Transform bulletTransform = Instantiate(bullet, bulletSpawn.position, Quaternion.identity);
        //Finding bullet direction
        Vector3 shootDir = (transform.position - bulletSpawn.position).normalized;
        bulletTransform.GetComponent<BulletController>().Setup(shootDir);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed, reloadTime, dash;
    [SerializeField] private Transform bullet, bulletSpawn;
    private PlayerInput pi;
    private float timer, dashTimer, dirX, dirZ, mousePos;
    private bool fireStart;

    private void Awake()
    {
        //Gamepad input
        pi = new PlayerInput();
        pi.Gameplay.Fire.performed += context => fireStart = true;
        pi.Gameplay.Fire.canceled += context => fireStart = false;
        pi.Gameplay.Dash.started += context => dashTimer = dash;
        pi.Gameplay.Exit.performed += context => Application.Quit();
    }
    private void OnEnable()
    { pi.Enable(); }
    private void OnDisable()
    { pi.Disable(); }
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void FixedUpdate()
    {
        //Reload timer
        if (timer >= 0) timer -= Time.fixedDeltaTime;

        //Rotating (Gamepad)
        float rotateY = pi.Gameplay.RotateX.ReadValue<float>();
        transform.Rotate(0f, rotateY * speed, 0f);

        //Rotating(Mouse)
        mousePos = pi.Gameplay.Mouse.ReadValue<float>();
        transform.Rotate(0f, mousePos * Time.fixedDeltaTime * 10f, 0f);
        

        //Moving
        dirX = pi.Gameplay.MoveX.ReadValue<float>();
        dirZ = pi.Gameplay.MoveZ.ReadValue<float>();
        rb.velocity = new Vector3(dirX * speed, rb.velocity.y, dirZ * speed);
        if (dashTimer >= 0)
        {
            dashTimer -= Time.fixedDeltaTime;
            rb.velocity = new Vector3(dirX * speed * 10, rb.velocity.y, dirZ * speed * 10);
        }
        dirX = 0;
        dirZ = 0;

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

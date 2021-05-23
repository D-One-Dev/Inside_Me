using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed, reloadTime, dash;
    [SerializeField] private Transform bullet, bulletSpawn;
    private PlayerInput pi;
    private float timer, dashTimer, dirX, dirZ;
    private bool moveW, moveA, moveS, moveD, fireStart;

    private void Awake()
    {
        //Gamepad input
        pi = new PlayerInput();
        pi.Gameplay.Fire.performed += context => fireStart = true;
        pi.Gameplay.Fire.canceled += context => fireStart = false;

        pi.Gameplay.Dash.started += context => dashTimer = dash;

        pi.Gameplay.MoveW.started += context => moveW = true;
        pi.Gameplay.MoveW.canceled += context => moveW = false;

        pi.Gameplay.MoveA.started += context => moveA = true;
        pi.Gameplay.MoveA.canceled += context => moveA = false;

        pi.Gameplay.MoveS.started += context => moveS = true;
        pi.Gameplay.MoveS.canceled += context => moveS = false;

        pi.Gameplay.MoveD.started += context => moveD = true;
        pi.Gameplay.MoveD.canceled += context => moveD = false;
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
        CountDirection();
        //Moving and rotating
        float rotateY = pi.Gameplay.RotateX.ReadValue<float>();
        transform.Rotate(0f, rotateY * speed, 0f);
        rb.velocity = new Vector3(dirX * speed, rb.velocity.y, dirZ * speed);
        if (dashTimer >= 0)
        {
            //Debug.Log(1);
            dashTimer -= Time.fixedDeltaTime;
            rb.velocity = new Vector3(dirX * speed * 10, rb.velocity.y, dirZ * speed * 10);
        }
        dirX = 0;
        dirZ = 0;
        Move();
        //Fire
        if (fireStart && timer < 0) Fire();
        Debug.Log(dashTimer);
    }

    private void CountDirection()
    {
        if (moveW | moveA | moveS | moveD)
        {
            if (moveW && dirZ < 1) dirZ++;
            if (moveA && dirX > -1) dirX--;
            if (moveS && dirZ > -1) dirZ--;
            if (moveD && dirX < 1) dirX++;
        }
        else
        {
            dirX = pi.Gameplay.MoveX.ReadValue<float>();
            dirZ = pi.Gameplay.MoveZ.ReadValue<float>();
        }
    }
    private void Move()
    {
        
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform player, plane;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    private int moveX, moveZ;
    public int health;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        plane = GameObject.Find("Plane").GetComponent<Transform>();
        health = 10;
    }
    void FixedUpdate()
    {
        Move();
        if (this.health <= 0)
        {
            //Creating new enemy and destroying current
            Vector3 spawnPoint = new Vector3(Random.Range(plane.position.x - plane.localScale.x, plane.position.x + plane.localScale.x), this.transform.position.y, Random.Range(plane.position.z - plane.localScale.z, plane.position.z + plane.localScale.z));
            Instantiate(enemyPrefab, spawnPoint, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    private void Move()
    {
        //Moving to the player
        if (player.position.x > transform.position.x) moveX = 1;
        else if (player.position.x < transform.position.x) moveX = -1;
        else moveX = 0;

        if (player.position.z > transform.position.z) moveZ = 1;
        else if (player.position.z < transform.position.z) moveZ = -1;
        else moveZ = 0;

        rb.velocity = new Vector3(moveX * speed, 0f, moveZ * speed);
    }
}

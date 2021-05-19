using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 shootDirection;
    private float timer;
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        //Moving the bullet
        transform.position -= shootDirection * speed * Time.fixedDeltaTime;
        //Destroying the bullet
        timer += Time.fixedDeltaTime;
        if (timer > 5f)
        {
            Destroy(this.gameObject);
        }
    }
    public void Setup(Vector3 shootDir)
    {
        //Setting up bullet direction
        shootDirection = shootDir;
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Collision with enemies
        if (collision.gameObject.GetComponent<EnemyController>() != null)
        {
            collision.gameObject.GetComponent<EnemyController>().health -= 1;
            Destroy(this.gameObject);
        }
    }
}

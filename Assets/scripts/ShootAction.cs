using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAction : MonoBehaviour
{
    public float speed = 17f;
    public Rigidbody2D rb;
    int damage = 20;

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy  = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.takeDamage(damage);
        }
        Destroy(gameObject);
    }
}

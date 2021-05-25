using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]
    int speed = 3;
    [SerializeField]
    int addSpeed = 8;
    Rigidbody2D rb;

    public bool border = true;
    public float minX = 2f;
    public float maxX = 65f;
    public float minY = -4f;
    public float maxY = 4f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        rb.velocity = new Vector2(speed, 0);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(addSpeed * Input.GetAxis("Horizontal"), rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, speed * Input.GetAxis("Vertical"));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, speed * Input.GetAxis("Vertical"));
        }

        if (border == true)
        {
            transform.position = new Vector2(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY));
        }
    }
}

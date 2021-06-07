using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    [SerializeField]
    int speed = 3;
    [SerializeField]
    int addSpeed = 8;
    Rigidbody2D rb;

    private bool border = true;
    private float minX = 2f;
    private float maxX = 100f;
    private float minY = -4f;
    private float maxY = 4f;

    float t = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        IsWin();
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

    void IsWin()
    {
        if (transform.position.x >= maxX)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}

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

    public int playerHealth = 3;

    public GameObject Player;

    //public bool border;

    //public float minX;
    //public float maxX;

    //public float minY;
    //public float maxY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
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

        //if (border == true)
        //{
        //    transform.position = new Vector2(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY));
        //}

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            playerHealth = playerHealth - 1;
            Debug.Log(playerHealth);
        }

        if (playerHealth <= 0)
        {
            Debug.Log("you are died");
            Destroy(Player);
        }
    }
}

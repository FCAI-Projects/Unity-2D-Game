using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyplayer : MonoBehaviour
{

    public int playerHealth = 3;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            playerHealth -= 1;
            Debug.Log(playerHealth);
        }

        if (playerHealth == 0)
        {
            Destroy(gameObject);
        }
    }
}

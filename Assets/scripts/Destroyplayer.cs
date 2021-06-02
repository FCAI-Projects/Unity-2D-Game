using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Destroyplayer : MonoBehaviour
{

    public int playerHealth = 3;
    public Text HealthText;

    // Start is called before the first frame update
    void Start()
    {
        HealthText.text = playerHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            -- playerHealth;
            HealthText.text = playerHealth.ToString();
            Debug.Log(playerHealth);

            if (playerHealth <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

                Destroy(gameObject);
            }
        }
    }
}

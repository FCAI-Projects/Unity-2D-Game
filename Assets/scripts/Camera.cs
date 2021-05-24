using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    [SerializeField]
    public float offest;
    private Vector3 playerPosition;
    [SerializeField]
    public float offsetSmoothing;
    internal static object current;

    // Start is called before the first frame update
    void Start()
    {
        if (player != null)
        {
            playerPosition = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
            if (player.transform.localScale.x > 0f)
            {
                playerPosition = new Vector3(playerPosition.x + offest, playerPosition.y, playerPosition.z);
            }
            else
            {
                playerPosition = new Vector3(playerPosition.x - offest, playerPosition.y, playerPosition.z);
            }

            transform.position = Vector3.Lerp(transform.position, playerPosition, offsetSmoothing * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null) 
        {
            playerPosition = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
            if (player.transform.localScale.x > 0f)
            {
                playerPosition = new Vector3(playerPosition.x + offest, playerPosition.y, playerPosition.z);
            }
            else
            {
                playerPosition = new Vector3(playerPosition.x - offest, playerPosition.y, playerPosition.z);
            }

            transform.position = Vector3.Lerp(transform.position, playerPosition, offsetSmoothing * Time.deltaTime);
        }
    }
}

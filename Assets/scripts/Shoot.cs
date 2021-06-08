using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject shootObj;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            createShoot();
        }
    }

    void createShoot()
    {
        Instantiate(shootObj, firePoint.position, firePoint.rotation);
    }
}

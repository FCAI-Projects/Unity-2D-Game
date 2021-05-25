using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    bool allowFire = true;
    public Transform firePoint;
    public GameObject shootObj;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            
            StartCoroutine(ExampleCoroutine());
        }
    }

    void createShoot()
    {
        Instantiate(shootObj, firePoint.position, firePoint.rotation);
    }

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        if (allowFire)
        {
            allowFire = false;
            createShoot();
            yield return new WaitForSeconds(0.3f);
            createShoot();
            yield return new WaitForSeconds(0.3f);
            createShoot();
            yield return new WaitForSeconds(2);
            allowFire = true;
        }
    }
}

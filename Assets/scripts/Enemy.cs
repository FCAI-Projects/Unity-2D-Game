using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 start;
    [SerializeField]
    float hight = 3;
    [SerializeField]
    float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyAnimation());
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator EnemyAnimation()
    {
        Vector3 end = new Vector3(transform.position.x, start.y + hight, start.z);
        bool isMove = true;
        float value = 0;

        while (true)
        {
            yield return null;
            if (isMove)
            {
                transform.position = Vector2.Lerp(start, end, value);
            }
            else
            {
                transform.position = Vector2.Lerp(end, start, value);
            }

            value = value + Time.deltaTime * speed;
            if (value > 1)
            {
                value = 0;
                isMove = !isMove;
            }
        }
    }
}

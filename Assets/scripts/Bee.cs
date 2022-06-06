using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour
{
    public GameObject Player;
    public Vector2 posFlower;
    public Transform point;
    public float speed;
    void Start()
    {
        point.position = Player.GetComponent<Mouse>().Points[Random.Range(0, 39)].position;
        posFlower = point.position - transform.position;
        transform.Translate(posFlower.normalized * speed);

    }

    void FixedUpdate()
    {
        if (transform.position == point.position)
        {
            speed = 0;
        }
        else
        {
            //transform.Translate(posFlower.normalized * speed);
        }
    }
}

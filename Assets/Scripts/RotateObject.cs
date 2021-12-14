using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    Vector3 pointA;
    Vector3 pointB;
    float speed = 0.1f;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        pointA = transform.eulerAngles + new Vector3(35f, 0f, 0f);
        pointB = transform.eulerAngles + new Vector3(-20f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        time = Mathf.PingPong(Time.time * speed, 1);
        transform.eulerAngles = Vector3.Lerp(pointA, pointB, time);
    }
}

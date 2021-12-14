using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(new Vector3(0, 0, +10 * Time.deltaTime));
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(new Vector3(0, 0, -10 * Time.deltaTime));
            
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(new Vector3(-10 * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(new Vector3(10 * Time.deltaTime, 0, 0));
         
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(new Vector3(0, 10 * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(new Vector3(0, -10 * Time.deltaTime, 0));
        }
        yaw += 2.0f * Input.GetAxis("Mouse X");
        pitch -= 2.0f * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}

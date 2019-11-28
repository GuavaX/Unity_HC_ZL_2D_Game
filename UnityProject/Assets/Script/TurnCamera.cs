using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnCamera : MonoBehaviour
{
    public float x;
    public float y;
    public float xSpeed;
    public float ySpeed;

    private Quaternion rotationEuler;

    void LateUpdate()
    {
        x += Input.GetAxis("Mouse X") * xSpeed * Time.deltaTime;
        y += Input.GetAxis("Mouse Y") * ySpeed * Time.deltaTime;

        if (x > 360)
        {
            x -= 360;
        }
        else if (x<0)
        {
            x += 360;
        }


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

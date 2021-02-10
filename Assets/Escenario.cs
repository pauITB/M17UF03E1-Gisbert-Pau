using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escenario : MonoBehaviour
{
    Vector3 rotacion = new Vector3(0,0,0);
    float smooth = 5.0f;
    float tiltAngle = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Smoothly tilts a transform towards a target rotation.
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);

/*
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rotacion = new Vector3(4f,0,0);

            transform.rotation = Quaternion.Slerp(transform.rotation, rotacion,  Time.deltaTime * 1);
            //transform.Rotate(rotacion);
        }
        else
        {
            transform.rotation =Quaternion.Slerp(transform.rotation, new Vector3(0,0,0),  Time.deltaTime * 1);
        }
*/

        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroController : MonoBehaviour
{
    Rigidbody rb ;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        rb.freezeRotation = true;
        if(Input.GetKey("right"))
        {
            transform.Rotate(Vector3.up, 0.5f);
        }
        else if(Input.GetKey("left"))
        {
            transform.Rotate(Vector3.up, -0.5f);
        }

        

        if(Input.GetKey("space"))
        {

            //rb.freezeRotation = true;
            rb.AddForce(10.0f * (transform.rotation * Vector3.forward));
        }
    }
}

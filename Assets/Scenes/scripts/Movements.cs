using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] private float boost = 1000f;
    [SerializeField] private float rotation = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessBoost();  
        ProcessRotation();
    }

    void ProcessBoost()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * boost * Time.deltaTime);           
        }

    }

    void ProcessRotation()
    {   
        if (Input.GetKey(KeyCode.A))
        {
            rotationMetod(rotation);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rotationMetod(-rotation);
        }

       void rotationMetod(float rotationForce)
       {
            rb.freezeRotation = true;
            transform.Rotate(Vector3.forward * rotationForce * Time.deltaTime);
            rb.freezeRotation = false;
       }


    }

}

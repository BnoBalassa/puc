using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WeaponController : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        FireMoviment();
    }

    private void FireMoviment()
    {  
        rb.AddForce(transform.forward, ForceMode.Impulse);
    }
}

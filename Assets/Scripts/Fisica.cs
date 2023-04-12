using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisica : MonoBehaviour
{

    RaycastHit hit;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log(collision.gameObject.name);
        };
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
    }

    private void Update()
    {
        if(Physics.Raycast(this.transform.position, this.transform.forward,out hit, 10))
        {
            Destroy(hit.collider.gameObject);
        }
   
    }
}

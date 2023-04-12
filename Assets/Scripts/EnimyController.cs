using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimyController : MonoBehaviour
{
    [SerializeField]
    private new ParticleSystem particleSystem;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pizza")
        {
            particleSystem.gameObject.SetActive(true);
            particleSystem.Play();
                
        }
    }
}

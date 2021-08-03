using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCollision : MonoBehaviour
{



    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLLIDER: I just hit the " + collision.gameObject.name + " collision.");

        // Destroy(collision.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER: I just went through the " + other.gameObject.name + " trigger.");

        // Destroy(other.gameObject);
    }

}

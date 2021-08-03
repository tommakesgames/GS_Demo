using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    // Create variable for rigidbody
    Rigidbody rb;

    // Create variable for speed of ball at launch (this is set from LaunchScript on the ballLauncher object).
    public float forceSpeed;

    // Start is called before the first frame update
    void Start()
    {
        // Assign rb variable
        rb = GetComponent<Rigidbody>();

        // Add a launch force to the ball.
        rb.AddForce(forceSpeed * transform.forward, ForceMode.Impulse);

        // Destroys this object 3 seconds after creation.
        Destroy(gameObject, 3);
    }


}

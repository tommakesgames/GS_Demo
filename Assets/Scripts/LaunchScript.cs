using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScript : MonoBehaviour
{
    public GameObject ball;

    public float forceSpeed;



    // Using 'Launch' Action defined in 'DemoClick' InputAsset.
    public void OnLaunch()
    {
        //Instantiate the ball and give it a name/reference.
        GameObject gO = Instantiate(ball, transform.position, transform.rotation);

        // Use this reference to set the launch speed of the ball to the value set in this script in the inspector.
        gO.GetComponent<ballMovement>().forceSpeed = forceSpeed;
    }
}

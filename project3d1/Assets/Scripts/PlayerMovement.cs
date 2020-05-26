using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sideWaysForce = 500f;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    // However we will mark this as "Fixed"Update because
    // we are using it for physics
    void FixedUpdate() {
        // Time.deltaTime is the time taken to create a new frame.
        // Also AddForce requires x,y and z axis.
        // The numbers here means force of 2000 is applies
        // on the z-axis.
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        // Input.GetKey() here will check if it the same input key
        // and if correct will execute the if statement
        if (Input.GetKey("d"))
        {
            // Adding force to the body overtime it slowely builds
            // up momentum and to change the direction of the object
            // we have to wait for the object to buildup enough force 
            // to change the direction of the object.
            // Here ForceMode will be used as the fourth parameter.
            // ForceMode.VelocityChange adds an instant velocity change in
            // the rigid body ignoring its mass.
            rb.AddForce(sideWaysForce *  Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysForce *  Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().endGame();
        }
    }
}

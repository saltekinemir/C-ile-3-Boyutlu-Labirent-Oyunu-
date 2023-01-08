using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardback_move = 20f;
    public float side_move = 50f;


    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardback_move * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardback_move * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(side_move * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-side_move * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}

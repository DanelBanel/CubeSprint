using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float forwardForce = 2000f;
    // Force applied to move the player sideways
    [SerializeField] private float moveForce = 1000f;

    void Start()
    {

    }
    // FixedUpdate is called once per frame, at a fixed interval
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        GetInputAndApplyForce();
    }
    void GetInputAndApplyForce()
    {
        if (Input.GetKey("a"))
        {
            Debug.Log("Moving left");
            rb.AddForce(-moveForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            Debug.Log("Moving right");
            rb.AddForce(moveForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown("r"))
        {
            Debug.Log("Resetting player position");
            // TODO fix position so it doesn't go below the ground and fix so it does not start to rotate at reset
            // For the latter maybe rb.RigidbodyConstraints.FreezeRotationXYZ; for 1 seconds at reset and startup
            transform.position = new Vector3(0, 0, 0);
        }
    }
}


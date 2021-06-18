using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;

    public float forwardMovementSpeed = 500f;
    public float sidesMovementSpeed = 500f;

    private void FixedUpdate() {
        moveForward();
        moveSides();
    }

    private void moveSides() {
        if (Input.GetKey("a")) {
            rigidBody.AddForce(-sidesMovementSpeed * Time.deltaTime, 0, 0);
        } 

        if (Input.GetKey("d")) {
            rigidBody.AddForce(sidesMovementSpeed * Time.deltaTime, 0, 0);
        }
    }

    private void moveForward() {
        if (Input.GetKey("w"))
        {
            rigidBody.AddForce(0, 0, forwardMovementSpeed * 2 * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            
        }
        rigidBody.AddForce(0, 0, forwardMovementSpeed * Time.deltaTime);

    }
}

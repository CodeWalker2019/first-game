using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;

    public int forwardMovementSpeedPoints = 9;
    public float sidewaysMovementSpeedNewtons = 500f;

    private void FixedUpdate() {
        forwardMovement();
        movementLeftRight();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            forwardMovementSpeedPoints = 0;
            sidewaysMovementSpeedNewtons = 0.000f;
        }
        if (collision.gameObject.tag == "Camera change")
        {
            Debug.Log("enter");
        }
    }

    private void movementLeftRight() {
        rigidBody.AddForce(sidewaysMovementSpeedNewtons * Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
    }

    private void forwardMovement() {
        transform.position += Vector3.forward * forwardMovementSpeedPoints * Time.deltaTime;
    }
}

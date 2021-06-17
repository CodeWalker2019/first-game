using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;

    private void FixedUpdate()
    {
        rigidBody.AddForce(0, 0, 1500 * Time.deltaTime);
    }
}

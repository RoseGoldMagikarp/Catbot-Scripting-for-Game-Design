using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;
    float xMovement;
    float zMovement;
    public float speed;
    public KeyCode right;
    public KeyCode left;
    public KeyCode forward;
    public KeyCode backward;

    public Vector3 minBounds;
    public Vector3 maxBounds;

    private void Update()
    {
        float xMovement = 0;
        float zMovement = 0;

        if (Input.GetKey(right))
        {
            xMovement += speed;
        }
        else if (Input.GetKey(left))
        {
            xMovement -= speed;
        }
        if (Input.GetKey(forward))
        {
            zMovement += speed;
        }
        else if (Input.GetKey(backward))
        {
            zMovement -= speed;
        }

        xMovement += this.transform.position.x;
        zMovement += this.transform.position.z;

        this.gameObject.transform.position = new Vector3(xMovement, this.transform.position.y, this.transform.position.z);
        this.gameObject.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, zMovement);

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, minBounds.x, maxBounds.x),
            Mathf.Clamp(transform.position.y, minBounds.y, maxBounds.y),
            Mathf.Clamp(transform.position.z, minBounds.z, maxBounds.z));
    }
}

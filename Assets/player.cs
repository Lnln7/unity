using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float speed = 5f;
    public float jumpP = 300f;

    Rigidbody2D rbody;





    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && rbody.velocity.y == -3) {
            rbody.AddForce(transform.up * jumpP);
        }
    }
    private void FixedUpdate()
    {
        rbody.velocity = new Vector2(speed, rbody.velocity.y);
    }
}

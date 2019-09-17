using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //float speedX = 5f;
    //float speedY = 5f;

    float horizontal;
    float vertical;

    float runSpeed = 5f;
    
    Rigidbody2D myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(0, Time.deltaTime * speedY, 0);
            myRigidBody.AddForce(new Vector2(0, speedY));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(0, Time.deltaTime * -speedY, 0);
            myRigidBody.AddForce(new Vector2(0, -speedY));
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(Time.deltaTime * -speedX, 0, 0);
            myRigidBody.AddForce(new Vector2(-speedX, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(Time.deltaTime * speedX, 0, 0);
            myRigidBody.AddForce(new Vector2(speedX, 0));
        }
        */

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        myRigidBody.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}

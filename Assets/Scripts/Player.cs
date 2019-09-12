using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speedX = 5f;
    float speedY = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, Time.deltaTime * speedY, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, Time.deltaTime * -speedY, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Time.deltaTime * -speedX, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Time.deltaTime * speedX, 0, 0);
        }
    }
}

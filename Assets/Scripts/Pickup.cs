using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "B")
        {
            Debug.Log("Hello");
            Speller.word = Speller.word + "B";
        }

        if (collision.gameObject.tag == "A")
        {
            Debug.Log("Hello");
            Speller.word = Speller.word + "A";
        }

        if (collision.gameObject.tag == "T")
        {
            Debug.Log("Hello");
            Speller.word = Speller.word + "T";
        }
    }
}

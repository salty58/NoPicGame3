using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speller : MonoBehaviour
{
    public static string word = "";
    Text wordText;

    bool form = false;


    // Start is called before the first frame update
    void Start()
    {
        wordText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        wordText.text = word;

        if(word.Length == 3)
        {
            form = true;
        }

        if(form == true)
        {
            if(word == "BAT")
            {

            }
        }
    }
}

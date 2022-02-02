using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, .5f, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, -.5f, 0);
        }
        if (Input.GetKey("down"))
        {
            transform.Rotate(.5f, 0, 0);
        }
        if (Input.GetKey("up"))
        {
            transform.Rotate(-.5f, 0, 0);
        }
        
    }
}

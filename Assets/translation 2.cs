using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.t))
        {
            animation.CrossFade ("pos0");
        }
        else
        {
            animation.CrossFade ("Dance");
        }
    }
}

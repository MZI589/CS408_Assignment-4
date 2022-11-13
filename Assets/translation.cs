using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject human;
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey ("f"))
        {
            human.GetComponent<Animator>().Play("pos1");
        }
        
        if (Input.GetKey ("b"))
        {
            human.GetComponent<Animator>().Play("pos2");
        }
        
        if (Input.GetKey ("g"))
        {
            human.GetComponent<Animator>().Play("pos2 0");
        }
        
        if (Input.GetKey ("s"))
        {
            human.GetComponent<Animator>().Play("Entry");
        }
    }
}

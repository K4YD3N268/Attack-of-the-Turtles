using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <para>MonoBehaviour is the base class from which every Unity script derives.</para>
public class Moving : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            transform.Translate(0, speed * Time.deltaTime, 0) ;
            //(x,y,z)
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0) ; 
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0) ;
        }

        if (Input.GetKey(KeyCode.D))
            transform.Translate(speed * Time.deltaTime, 0, 0) ;
    }
}

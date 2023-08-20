using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initialBackground : MonoBehaviour

{
    public Renderer rend;
    public CompositeCollider2D coll;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        coll = GetComponent<CompositeCollider2D>();
        rend.enabled = true;
        coll.enabled = true;



    }

    // Update is called once per frame
    void Update()
    {
        if(Brother.changeBackground)
        {
            rend.enabled = false;
            coll.enabled = false;
        }
    
}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orangeBrother : MonoBehaviour
{
    public Renderer rend;
    public Collider2D coll;
    // Start is called before the first frame update
    void Start()
    {
        GameObject orangeBro = GameObject.FindGameObjectWithTag("orange");


        transform.position = new Vector3(5.13f, -10.28f, 0f);


    }
    private void Awake()
    {
        rend = GetComponent<Renderer>();
        coll = GetComponent<Collider2D>();
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Brother.changeBackground)
        {
            transform.position = new Vector3(5.92f, -0.12f, 0f);

            coll.enabled = true;
            rend.enabled = true;

        }

    }
    
}

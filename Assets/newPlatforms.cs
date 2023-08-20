using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newPlatforms : MonoBehaviour
{
    public Renderer rend;
    public CompositeCollider2D coll;
    // Start is called before the first frame update
    void Start()
    {

        transform.position = new Vector3(-0.26f, -14.35f, 0f);


    }
    private void Awake()
    {
        rend = GetComponent<Renderer>();
        coll = GetComponent<CompositeCollider2D>();
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Brother.changeBackground)
        {
            transform.position = new Vector3(0f, 0f, 0f);

            coll.enabled = true;
            rend.enabled = true;
            
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayObjects : MonoBehaviour
{
    public Renderer rend;
    [SerializeField] public Vector3 _intialPos;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = _intialPos;
        rend = GetComponent<Renderer>();
        rend.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Brother.changeBackground)
        {
            rend.enabled = false;
        }
    }
}

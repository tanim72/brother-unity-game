using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endScene : MonoBehaviour
{
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0.0865f, 0.7541f, 0f);
        rend = GetComponent<Renderer>();
        rend.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (Brother.metBrother)
        {
            rend.enabled = true;
        }
        if(playAgain.retry)
        {
            rend.enabled = false;
        }

    }
}

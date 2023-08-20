using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playAgain : MonoBehaviour
{
    public Renderer rend;
    public static bool retry = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0.1f, -3.88f, 0f);
        rend = GetComponent<Renderer>();
        rend.enabled = false;


    }
    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Brother.metBrother)
        {
            rend.enabled = true;
        }

    }
    private void OnMouseDown()
    {
        rend.enabled = false;
        retry = true;
        
    }
}

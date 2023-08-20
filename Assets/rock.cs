using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    private Vector3 _initialPosition;
    public Renderer rend;
    public Collider2D coll;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(5.54f, -0.36f, 0f);
        _initialPosition = transform.position;
        rend = GetComponent<Renderer>();
        coll = GetComponent<Collider2D>();
        rend.enabled = true;
        coll.enabled = true;


    }

    // Update is called once per frame
    void Update()
    {
        if (Brother.changeBackground)
        {
            rend.enabled = false;
            coll.enabled = false;

        }
    }
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.black;

        Vector2 directionToInitialPosition = _initialPosition - transform.position;
        //GetComponent<Rigidbody2D>().AddForce(directionToInitialPosition * _launchPower);
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }

    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    private void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x, newPosition.y);
    }
}

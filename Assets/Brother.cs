using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brother : MonoBehaviour
{
    public static bool changeBackground;
    [SerializeField] public float ySpeed = 10f;
    public float nSpeed;
    private SpriteRenderer mySpriteRenderer; 
    Animator m_animator;
    private bool isTransfered = false;
    public static bool metBrother = false;
    

    public void Start()
    {
        nSpeed = 7f;
        m_animator = gameObject.GetComponent<Animator>();
        GameObject redBro = GameObject.FindGameObjectWithTag("red");

    }
    private void Awake()
    {
        transform.position = new Vector3(-10.4f, 3.62f, 0f);
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        changeBackground = false;
    }

    private void Update()
    {
        transform.Translate(nSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, ySpeed* nSpeed * Input.GetAxis("Vertical") * Time.deltaTime, 0f);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_animator.SetBool("isLeft", false);
            m_animator.SetBool("isRunning", true);
           
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_animator.SetBool("isLeft", true);
            m_animator.SetBool("isRunning", true);

        }
        else
        {
            m_animator.SetBool("isLeft", false);
            m_animator.SetBool("isRunning",false);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            m_animator.SetBool("isUp", true);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            m_animator.SetBool("isUp", false);
        }

        if (transform.position.y > 10.58)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if (transform.position.x < -13.97)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if (transform.position.x > 13.77)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if (transform.position.y < -9)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        if(playAgain.retry)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(transform.position.y<-0.19 && transform.position.y>-0.81 && transform.position.x>5.3 && transform.position.x<6.06)
        {
            changeBackground = true;
            if(!isTransfered)
            {
                transform.position = new Vector3(-10.4f, 3.62f, 0f);
                isTransfered = true;
            }
            
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "orange")
        {
            metBrother = true;
        }
    }

   
}

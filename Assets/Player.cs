using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float rotateSpeed = 200;
    public float moveSpeed = 0.015f;
    public float friction = 0.9985f;

    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    private Rigidbody2D rb;

    private bool isGrounded;

    private float playerRotation = -90;
    private float speed = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Spatie is ingedrukt");

        }
        playerRotation -= Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, playerRotation);

        speed += Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        speed *= friction;
        speed *= 1-(math.abs(Input.GetAxis("Horizontal"))*0.004f);
        transform.position += transform.up * speed;

        isGrounded = Physics2D.OverlapBox(groundCheck.position, new Vector2(groundCheckRadius, groundCheckRadius), 0f, groundLayer);
        //Debug.Log(isGrounded);
        if (isGrounded == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Collision detected with: " + collision.gameObject.name);
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log(collision.gameObject.transform.eulerAngles.z);

            playerRotation = collision.gameObject.transform.eulerAngles.z;
            speed = 0.0025f;
        }
    }
}

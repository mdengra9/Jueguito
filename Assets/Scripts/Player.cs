using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 5.5f;
    public float jumpforce = 3;
    float horizontal;

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rBody;
    private GroundSensor sensor;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        sensor = GameObject.Find("GroundSensor").GetComponent<GroundSensor>();
        rBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        if (horizontal < 0)
        {
            spriteRenderer.flipX = true;
            anim.SetBool("isRunning", true);
        }

        else if (horizontal > 0)
        {
            spriteRenderer.flipX = false;
            anim.SetBool("isRunning", true);
        }

        else
        {
           anim.SetBool("isRunning", false); 
        }

        if (Input.GetButtonDown("Jump") && sensor.isGrounded)
        {
            rBody.AddForce (Vector2.up * jumpforce, ForceMode2D.Impulse);
            anim.SetBool("isJumping", true); 
        }
    }

    void FixedUpdate() 
    {
        rBody.velocity = new Vector2(horizontal * playerSpeed, rBody.velocity.y);
    }
}

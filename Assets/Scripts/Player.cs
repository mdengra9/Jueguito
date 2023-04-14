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

    // Start is called before the first frame update
    void Start()
    {
        sensor = GameObject.Find("GroundSensor").GetComponent<GroundSensor>();
        rBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        if (horizontal < 0)
        {
            spriteRenderer.flipX = true;
        }

        else if (horizontal > 0)
        {
            spriteRenderer.flipX = false;
        }

        if (Input.GetButtonDown("Jump") && sensor.isGrounded)
        {
            rBody.AddForce (Vector2.up * jumpforce, ForceMode2D.Impulse);
        }
    }

    void FixedUpdate() 
    {
        rBody.velocity = new Vector2(horizontal*playerSpeed,rBody.velocity);
    }
}

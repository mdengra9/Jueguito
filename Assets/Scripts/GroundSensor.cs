using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    Player playerScript;
    public bool isGrounded;
    // Start is called before the first frame update

    void Start ()
    {
        playerScript= GetComponentInParent<Player>();
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {
            isGrounded = true;
            playerScript.anim.SetBool("isJumping", false);

        }
    }

    // Update is called once per frame
    void OnTriggerStay2D (Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {
            isGrounded = true;
        }
    }

    void OnTriggerExit2D (Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {
            isGrounded = false;
        }
    }
}

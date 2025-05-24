using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    float xDir;
    float yVel;
    Rigidbody2D rb;
    [SerializeField] float speed;
    [SerializeField] public static float maxJumpHeigh = 2.1f;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundMask;
    bool jump;
    bool faceright = true;
    float jumpStartY;
    RaycastHit2D groundCast;
    // Use this for initialization

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        groundCast = Physics2D.CircleCast(groundCheck.position, 0.1f, Vector2.down, 0.1f, groundMask);
        
        {
            xDir = Input.GetAxis("Horizontal");
            if (faceright && xDir < 0f || !faceright && xDir > 0f)
            {
                faceright = !faceright;
                transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
            }

            if (Input.GetButtonDown("Jump") && groundCast)
            {
                jump = true;
                jumpStartY = transform.position.y;

            }
            if (Input.GetButtonUp("Jump"))
            {
                jump = false;

            }

            if (jump)
            {
                yVel = 8f;
                if (transform.position.y > jumpStartY + maxJumpHeigh)
                {
                    jump = false;
                }
            }
            if (!jump && !groundCast)
            {
                yVel = -8f;
            }
            if (!jump && groundCast)
            {
                yVel = rb.velocity.y;
            }
            rb.velocity = new Vector2(xDir * speed, yVel);

        }

    }
}

       
        
    



using UnityEngine;

public class CarController : MonoBehaviour
{
    float yDir, xDir;
    float speed;
    float stop = 0.02f;
    int x = 10;
    Rigidbody2D rb;
    [SerializeField] float steering = 10f;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Manager.liveLeft >= 0)
        {
            yDir = Input.GetAxis("Vertical");
            xDir = Input.GetAxis("Horizontal");

            if (yDir > 0f)
            {
                if (speed < -stop)
                {
                    speed += Time.deltaTime * 8f;
                    
                }
                else
                {
                    speed += yDir * Time.deltaTime;

                }
            }
            else if (yDir < -0f)
            {
                if (speed < -stop)
                {
                    speed += yDir * Time.deltaTime / 2f;
                }
                else
                {
                    speed -= Time.deltaTime * 8f;
                }
            }
            else
            {
                if (speed > stop)
                {
                    speed -= Time.deltaTime;
                }
                else if (speed < -stop)
                {
                    speed += Time.deltaTime;
                }
                else
                {
                    speed = 0f;
                }
            }
            rb.velocity = transform.up * speed;

            if (speed > 0f)
            {
                rb.angularVelocity = -xDir * steering * speed;
            }
            else if (speed < 0)
            {
                rb.angularVelocity = xDir * steering * speed;
            }
            if (rb.angularVelocity == x)
            {
                rb.angularVelocity = x;
            }
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Manager.liveLeft--;
            transform.position = Manager.startPoint.position;
        }
    }
}

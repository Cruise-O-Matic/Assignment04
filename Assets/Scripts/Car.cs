using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{

    public Rigidbody2D rb;

    public float speed;
    float newSpeed = CarSpeed.ForwardSpeed;

    //public float minSpeed = 8f;
   // public float maxSpeed = 12f;

    //float speed = 1f;


    void Start()
    {
        //speed = Random.Range(minSpeed, maxSpeed);
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.deltaTime * newSpeed);
    }
   /*void update()
    {
        //transform.forward(speed*newSpeed*Time.deltaTime,0f,0f);

        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.deltaTime * speed);
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    Rigidbody2D rb2d;
    public float speed = 5;
    public bool onFloor = true;
    public SpriteRenderer spriteRenderer;
    public bool facingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        // gettings the rigidbody2d components necessary for the jumping
        rb2d = GetComponent<Rigidbody2D>();

        speed = 200f;

        // checks if the rigidbody2d componenets are applied, if not it returns a debug log
        if (rb2d == null)
        {
            Debug.Log("Rigidbody2D is missing");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // pressing d will move the player right
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddForce(Vector2.right * speed); //* Time.deltaTime);

            spriteRenderer.flipX = false; // keep if want to flip

            facingRight = true;

            ColliderAdjustRight();
        }

        // pressing a will move the player left
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddForce(Vector2.left * speed);// * Time.deltaTime);

            //transform.Translate(Vector2.left * speed * Time.deltaTime);

            spriteRenderer.flipX = true; // keep if want to flip

            //collider.offset = new Vector2(-collider.offset.x, collider.offset.y);

            ColliderAdjustLeft();

            facingRight = false;
        }

    }

    void ColliderAdjustLeft()
    {
        Collider2D collider = GetComponent<Collider2D>();


        if (collider != null)
        {
            if (facingRight == false)
            {
                // Flip the collider's offset horizontally
                Vector2 newOffset = collider.offset;
                newOffset.x = 1;
                collider.offset = newOffset;
            }
        }
    }

    void ColliderAdjustRight()
    {
        Collider2D collider = GetComponent<Collider2D>();
        if (collider != null)
        {
            if (facingRight == true)
            {
                // Flip the collider's offset horizontally
                Vector2 newOffset = collider.offset;
                newOffset.x = -1;
                collider.offset = newOffset;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    Rigidbody2D rb2d;
    public float speed = 5;
    public bool onFloor = true;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        Collider2D collider = GetComponent<Collider2D>();
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        // gettings the rigidbody2d components necessary for the jumping
        rb2d = GetComponent<Rigidbody2D>();

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
            //transform.Translate(Vector2.right * speed * Time.deltaTime);
            rb2d.AddForce(Vector2.right * speed); //* Time.deltaTime);
            //spriteRenderer.flipX = false; // keep if want to flip

        }

        // pressing a will move the player left
        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(Vector2.left * speed * Time.deltaTime);
            rb2d.AddForce(Vector2.left * speed);// * Time.deltaTime);
            //spriteRenderer.flipX = true; // keep if want to flip
            //collider.offset = new Vector2(-collider.offset.x, collider.offset.y);
        }

    }
}

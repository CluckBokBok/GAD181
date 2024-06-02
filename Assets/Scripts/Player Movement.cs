using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float speed = 5;
    public float jumpHeight = 5f;
    public bool onFloor = true;

    // Start is called before the first frame update
    void Start()
    {
        // gettings the rigidbody2d components necessary for the jumping
        rb2d = GetComponent<Rigidbody2D>();

        // checks if the rigidbody2d componenets are applied, if not it returns a debug log
        if (rb2d == null)
        {
            Debug.Log("Rigidbody2D is missing");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // pressing d will move the player right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        // pressing a will move the player left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        // pressing space while the player is touching the floor will result in a jump
        if (onFloor && Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            onFloor = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D thinghit)
    {
        // this checks if the player has collided with the floor
        if (thinghit.gameObject.CompareTag("Floor"))
        {
            onFloor = true;
            Debug.Log("player has hit the floor");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastAbilities : MonoBehaviour
{
    public MovementScript movingScript;

    public Vector2 leftBoundary;
    public Vector2 rightBoundary;

    // Start is called before the first frame update
    void Start()
    {
        leftBoundary = new Vector2(-8, transform.position.y);
        rightBoundary = new Vector2(8, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 9)
        {
            KeepPlayerInBounds(rightBoundary);
        }
        if (transform.position.x < -9)
        {
            KeepPlayerInBounds(leftBoundary);
        }

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            if (movingScript.facingRight == true)
            {
                transform.Translate(Vector2.right * 10);
            }
            else if (movingScript.facingRight == false)
            {
                transform.Translate(Vector2.left * 10);
            }
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            movingScript.speed = 200;
        }
    }

    void KeepPlayerInBounds(Vector2 newPosition)
    {
        transform.position = newPosition;
    }
}

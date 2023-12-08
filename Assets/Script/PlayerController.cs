using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody2D rb;
    float gravityForce = 13f;
    float jumpForce = 400f;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.gravity = new Vector2(0, -gravityForce);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Force);
            Debug.Log("Jump");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody2D rb;
    float gravityForce = 13f;
    float jumpForce = 800f;
    GameManager GM;
    int stage;
    bool moveUp;


    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        Physics2D.gravity = new Vector2(0, -gravityForce);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GM.stage == 1)
        {
            if (Input.GetMouseButtonUp(0))
            {
                rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Force);
                Debug.Log("Jump");
            }
        }
        else if (GM.stage >= 2)
        {
            Physics2D.gravity = Vector2.zero;
            if (moveUp)
            {
                rb.velocity = Vector2.up * 2000f * Time.deltaTime;
            }else if (!moveUp)
            {
                rb.velocity = Vector2.up * -2000f * Time.deltaTime;
            }

            if (Input.GetMouseButtonUp(0))
            {
                moveUp = !moveUp;
                
            }
        }
        
    }
}

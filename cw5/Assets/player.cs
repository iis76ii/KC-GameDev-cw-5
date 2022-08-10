using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    Rigidbody2D RB;
    float PlayerInput;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerInput = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(PlayerInput * speed, 0);
    }
}

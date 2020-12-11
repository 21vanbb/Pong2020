using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleScript : MonoBehaviour
{
    public float speed;
    private RigidBody2D rb; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetCompnonent<RigidBody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal") );
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleMovement : MonoBehaviour
{
    public float speed = 50.0f;
    public float rightScreen;
    public float leftScreen;
    public float xRange = 6.9f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontal * Time.deltaTime * speed);
        if(transform.position.x < leftScreen)
        {
            transform.position = new Vector2(leftScreen, transform.position.y);
        }
        if (transform.position.x > rightScreen)
        {
            transform.position = new Vector2(rightScreen, transform.position.y);
        }
    }
}
//16:08 on first video
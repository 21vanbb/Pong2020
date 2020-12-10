using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleScript : MonoBehaviour
{
    public float speed = 5.0f;
    public float rightEdge;
    public float leftEdge;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate (Vector2.right * horizontal * Time.deltaTime * speed);
        if(transform.position.x < leftEdge)
        {
            transform.position = new Vector2(leftEdge, transform.position.y);
        }
        if (transform.position.x > rightEdge)
        {
            transform.position = new Vector2(rightEdge, transform.position.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position; 
        }
    }
}

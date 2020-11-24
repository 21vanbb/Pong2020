using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public float yRange = 4.8f;
    public float xRange = 6.9f;
    public float speed = 5.0f;
    public float height = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void LateUpdate()
    {
        if (transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector2(yRange, transform.position.x);
        }
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector2(-yRange, transform.position.x);
        }
    }
}

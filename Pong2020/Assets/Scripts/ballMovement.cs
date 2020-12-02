using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public float yRange = 4.8f;
    public float xRange = 6.9f;
    public float MoveSpeed;
    public float height = 0.5f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = RandomVector(-5f, 5f);
        transform.gameObject.GetOrAddComponent<ColliderEventSystem>().ColliderEntered += PushObject;
    }

    private void PushObject(ColliderEventSystem eventTarget, Collider2D other)
    {
        float speed = 100;
        Vector3 direction = (transform.position - other.transform.position).normalized;
        rb.Addforce((direction * speed));
    }

    private Vector3 RandomVector(float min, float max)
    {
        var x = UnityEngine.Random.Range(min, max);
        var y = UnityEngine.Random.Range(min, max);
        return new Vector3(x, y);
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

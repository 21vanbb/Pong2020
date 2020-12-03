 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball initialBall;
    public Ball prefab;

    public Paddle paddle; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void intializeBall()
    {
        Vector3 paddlePos = paddle.gomeObject.transform.position;
    }
}

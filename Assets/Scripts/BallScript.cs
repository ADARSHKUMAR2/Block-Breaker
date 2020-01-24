using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] PaddleScript paddle1;
    Vector3 paddleToBallVector;
    bool hasStarted=false;
    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted)
        {
            LockBallToPaddle();
            LaunchBallOnClick();
        }
    }

    private void LockBallToPaddle()
    {
        Vector3 paddlePos = new Vector3(paddle1.transform.position.x, paddle1.transform.position.y, -6.4f);
        transform.position = paddlePos + paddleToBallVector;
    }
}

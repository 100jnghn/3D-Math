using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshCameraControl : MonoBehaviour
{
    public bool LeftMove = false;
    public bool RightMove = false;
    public bool UpMove = false;
    public bool DownMove = false;
    public bool FrontMove = false;
    public bool BackMove = false;



    public bool LeftRotate = false;
    public bool RightRotate = false;
    public bool UpRotate = false;
    public bool DownRotate = false;
    public bool ClockwiseRotate = false;
    public bool CounterClockwiseRotate = false;

    float moveSpeed = 5;

    float rotateSpeed = 50.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //이동
        //Vector3 moveDirection = Vector3.zero;

        //if (LeftMove)
        //{
        //    moveDirection += Vector3.left;
        //}
        //if (RightMove)
        //{
        //    moveDirection += Vector3.right;
        //}
        //if (UpMove)
        //{
        //    moveDirection += Vector3.up;
        //}
        //if (DownMove)
        //{
        //    moveDirection += Vector3.down;
        //}
        //if (FrontMove)
        //{
        //    moveDirection += Vector3.forward;
        //}
        //if (BackMove)
        //{
        //    moveDirection += Vector3.back;
        //}

        //transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);


        //회전
        Vector3 rotateDirection = Vector3.zero;

        if (LeftRotate)
        {
            rotateDirection += Vector3.up;
        }
        if (RightRotate)
        {
            rotateDirection += Vector3.down;
        }
        if (UpRotate)
        {
            rotateDirection += Vector3.left;
        }
        if (DownRotate)
        {
            rotateDirection += Vector3.right;
        }
        if (ClockwiseRotate)
        {
            rotateDirection += Vector3.forward;
        }
        if (CounterClockwiseRotate)
        {
            rotateDirection += Vector3.back;
        }

        transform.Rotate(rotateDirection * rotateSpeed * Time.deltaTime, Space.World);

    }
}

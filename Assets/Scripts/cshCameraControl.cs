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


    float rotateSpeed = 50.0f;


    public Transform pivotPoint;//원점 지정 예정


    // Start is called before the first frame update
    void Start()
    {
        // pivotPoint를 지정하지 않았을 경우 기본으로 원점 사용
        if (pivotPoint == null)
        {
            GameObject go = new GameObject("PivotPoint");
            go.transform.position = Vector3.zero;
            pivotPoint = go.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //회전
        if (LeftRotate)
        {
            transform.RotateAround(pivotPoint.position, Vector3.up, rotateSpeed * Time.deltaTime);
        }
        if (RightRotate)
        {
            transform.RotateAround(pivotPoint.position, Vector3.down, rotateSpeed * Time.deltaTime);
        }
        if (UpRotate)
        {
            transform.RotateAround(pivotPoint.position, Vector3.left, rotateSpeed * Time.deltaTime);
        }
        if (DownRotate)
        {
            transform.RotateAround(pivotPoint.position, Vector3.right, rotateSpeed * Time.deltaTime);
        }
        if (ClockwiseRotate)
        {
            transform.RotateAround(pivotPoint.position, Vector3.forward, rotateSpeed * Time.deltaTime);
        }
        if (CounterClockwiseRotate)
        {
            transform.RotateAround(pivotPoint.position, Vector3.back, rotateSpeed * Time.deltaTime);
        }
    }
}
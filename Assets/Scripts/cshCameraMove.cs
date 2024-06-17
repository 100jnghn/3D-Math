using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshCameraMove : MonoBehaviour
{
    public GameObject camera_Main;
    cshCameraControl CameraControl;

    // Start is called before the first frame update
    void Start()
    {
        CameraControl = camera_Main.GetComponent<cshCameraControl>();
    }



    void Update()
    {

    }

    public void LeftBtn()
    {
        CameraControl.LeftRotate = true;
    }
    public void LeftBtnUp()
    {
        CameraControl.LeftRotate = false;
    }

    public void UpBtn()
    {
        CameraControl.UpRotate = true;
    }
    public void UpBtnUp()
    {
        CameraControl.UpRotate = false;
    }

    public void DownBtn()
    {
        CameraControl.DownRotate = true;
    }
    public void DownBtnUp()
    {
        CameraControl.DownRotate = false;
    }

    public void RightBtn()
    {
        CameraControl.RightRotate = true;
    }
    public void RightBtnUp()
    {
        CameraControl.RightRotate = false;
    }

    public void FrontBtn()
    {
        CameraControl.ClockwiseRotate = true;
    }
    public void FrontBtnUp()
    {
        CameraControl.ClockwiseRotate = false;
    }

    public void BackBtn()
    {
        CameraControl.CounterClockwiseRotate = true;
    }
    public void backBtnUp()
    {
        CameraControl.CounterClockwiseRotate = false;
    }


}

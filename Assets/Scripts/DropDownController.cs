using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDownController : MonoBehaviour
{
    private TMP_Dropdown dropdown;

    public GameObject quizPanel;
    public GameObject addPointPanel;
    public GameObject pointInputPanel;
    public GameObject vectorStartButton;
    public GameObject vectorEndButton;
    public GameObject deleteButton;
    public GameObject RotationPanel;

    public Camera camera;

   

    void Start()
    {
        dropdown = GetComponent<TMP_Dropdown>();
        dropdown.onValueChanged.AddListener(OnDropDownEvent);
    }

    void Update()
    {
        
    }

    public void OnDropDownEvent(int index)
    {
        switch (index)
        {
            case 0: // Select Options
                quizPanel.SetActive(false);
                addPointPanel.SetActive(false);
                pointInputPanel.SetActive(false);
                vectorStartButton.SetActive(false);
                vectorEndButton.SetActive(false);
                deleteButton.SetActive(false);
                RotationPanel.SetActive(false);

                break;

            case 1: // Dot, Line, Surface
                quizPanel.SetActive(false);
                addPointPanel.SetActive(true);
                pointInputPanel.SetActive(false);
                vectorStartButton.SetActive(false);
                vectorEndButton.SetActive(false);
                deleteButton.SetActive(true);
                RotationPanel.SetActive(false);

                break;

            case 2: // 3D Polygon
                quizPanel.SetActive(false);
                addPointPanel.SetActive(false);
                pointInputPanel.SetActive(false);
                vectorStartButton.SetActive(false);
                vectorEndButton.SetActive(false);
                deleteButton.SetActive(false);
                RotationPanel.SetActive(false);

                break;

            case 3: // Vector
                quizPanel.SetActive(false);
                addPointPanel.SetActive(false);
                pointInputPanel.SetActive(false);
                vectorStartButton.SetActive(false);
                vectorEndButton.SetActive(false);
                deleteButton.SetActive(false);
                RotationPanel.SetActive(false);

                break;

            case 4: // Graphics
                quizPanel.SetActive(false);
                addPointPanel.SetActive(false);
                pointInputPanel.SetActive(false);
                vectorStartButton.SetActive(false);
                vectorEndButton.SetActive(false);
                deleteButton.SetActive(false);
                RotationPanel.SetActive(false);

                break;

            case 5: // Quiz
                quizPanel.SetActive(true);
                addPointPanel.SetActive(true);
                pointInputPanel.SetActive(false);
                vectorStartButton.SetActive(false);
                vectorEndButton.SetActive(false);
                deleteButton.SetActive(true);
                RotationPanel.SetActive(false);

                break;

            case 6: // Rotation_OnOff
       
                RotationPanel.SetActive(true);
                Projection();

                quizPanel.SetActive(false);
                addPointPanel.SetActive(false);
                pointInputPanel.SetActive(false);
                vectorStartButton.SetActive(false);
                vectorEndButton.SetActive(false);
                deleteButton.SetActive(false);

                break;

            default:
                break;
        }
    }


    public void Projection()
    {
        //카메라 위치
        camera.transform.position = new Vector3(0, 0, -7);

        //원점을 바라보도록.
        camera.transform.LookAt(Vector3.zero);

        camera.transform.up = Vector3.up;
    }

}

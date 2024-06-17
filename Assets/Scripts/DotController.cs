using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DotController : MonoBehaviour
{
    private DotManager dotManager;

    public string dotName;                  // 점의 이름
    public TextMeshProUGUI positionText;    // UI에 들어갈 텍스트: A(0,0,0)


    void Start()
    {
        dotManager = GameObject.Find("DotManager").GetComponent<DotManager>();
    }

    void Update()
    {
        detectTouch();
    }

    // 점의 이름 설정
    public void setName(string dotName)
    {
        this.dotName = dotName;
    }

    // 사용자 input으로 position 입력받음. z값은 여기서 부호 반전
    public void setPosition(float x, float y, float z)
    {
        Vector3 pos = new Vector3(x, y, z * -1);
        transform.position = pos;
    }

    // UI에 들어갈 텍스트 설정. A(0,0,0)
    public void setText()
    {
        positionText.text = dotName + "(" + transform.position.x + " " + transform.position.y + " " + transform.position.z * -1 + ")";
    }

    // 생성된 점을 터치했을 때 -> 이름, 위치 변경 가능
    void detectTouch()
    {
        // 터치가 하나 이상 발생
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);    // 첫 번째 터치 가져옴

            // 터치가 시작된 순간
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform == this.transform)
                    {
                        dotManager.selectedDot = gameObject;
                        dotManager.changeUI();
                    }
                }
            }
        }
    }

    
}

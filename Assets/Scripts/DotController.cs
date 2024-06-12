using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DotController : MonoBehaviour
{
    private DotManager dotManager;

    public string dotName;                  // ���� �̸�
    public TextMeshProUGUI positionText;    // UI�� �� �ؽ�Ʈ: A(0,0,0)


    void Start()
    {
        dotManager = GameObject.Find("DotManager").GetComponent<DotManager>();
    }

    void Update()
    {
        detectTouch();
    }

    // ���� �̸� ����
    public void setName(string dotName)
    {
        this.dotName = dotName;
    }

    // ����� input���� position �Է¹���. z���� ���⼭ ��ȣ ����
    public void setPosition(float x, float y, float z)
    {
        Vector3 pos = new Vector3(x, y, z * -1);
        transform.position = pos;
    }

    // UI�� �� �ؽ�Ʈ ����. A(0,0,0)
    public void setText()
    {
        positionText.text = dotName + "(" + transform.position.x + " " + transform.position.y + " " + transform.position.z * -1 + ")";
    }

    // ������ ���� ��ġ���� �� -> �̸�, ��ġ ���� ����
    void detectTouch()
    {
        // ��ġ�� �ϳ� �̻� �߻�
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);    // ù ��° ��ġ ������

            // ��ġ�� ���۵� ����
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

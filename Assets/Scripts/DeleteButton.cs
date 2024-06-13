using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteButton : MonoBehaviour
{
    private bool isBtnClicked = false;
    
    public void onBtnClick()
    {
        isBtnClicked = true;
    }

    private void Update()
    {
        if (isBtnClicked)
        {
            touchObject();
        }
    }

    private void touchObject()
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
                    if (hit.transform.gameObject.CompareTag("Dot") || hit.transform.gameObject.CompareTag("Vector"))
                    {
                        Destroy(hit.transform.gameObject);
                        isBtnClicked = false;
                    }
                }
            }
        }
    }
}

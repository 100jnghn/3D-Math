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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorManager : MonoBehaviour
{
    public DotManager dotManager;
    public GameObject vecStartButton;
    public GameObject vecEndButton;
    public GameObject vecBodyPrefab;
    public GameObject vecHeadPrefab;

    private GameObject startDot = null;
    private GameObject endDot = null;

    void Start()
    {
        
    }

    void Update()
    {
        if (startDot != null && endDot != null)
        {
            makeVec();
        }

        if (dotManager.selectedDot != null)
        {
            vecStartButton.SetActive(true);
            vecEndButton.SetActive(true);
        }
        else
        {
            vecStartButton.SetActive(false);
            vecEndButton.SetActive(false);
        }
    }

    // 점을 선택한 상태에서 startVec으로 지정
    public void setStartVec()
    {
        startDot = dotManager.selectedDot;
    }

    // 점을 선택한 상태에서 endVec으로 지정
    public void setEndVec()
    {
        endDot = dotManager.selectedDot;
    }

    // 벡터 화살표 만들기
    private void makeVec()
    {
        // 시작 위치와 끝 위치
        Vector3 startPos = startDot.transform.position;
        Vector3 endPos = endDot.transform.position;

        // 중간 지점과 벡터의 방향
        Vector3 middlePos = (startPos + endPos) / 2f;
        Vector3 dir = (endPos - startPos).normalized;

        // 벡터 회전값
        Quaternion rotation = Quaternion.LookRotation(dir) * Quaternion.Euler(90,0,0);

        // 벡터 생성(몸통)
        GameObject body = Instantiate(vecBodyPrefab, middlePos, rotation);

        // 벡터 크기 변경
        float distance = Vector3.Distance(startPos, endPos);
        Vector3 scale = body.transform.localScale;
        scale.y = distance / 2;
        body.transform.localScale = scale;

        // 벡터 머리(화살표) 만들기
        Vector3 arrowPos = body.transform.GetChild(0).transform.position;
        Quaternion arrowRot = rotation * Quaternion.Euler(90, 0, 0);
        Instantiate(vecHeadPrefab, arrowPos, arrowRot);

        // 다시 null로 초기화
        startDot = null;
        endDot = null;
    }
}

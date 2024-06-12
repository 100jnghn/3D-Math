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

    // ���� ������ ���¿��� startVec���� ����
    public void setStartVec()
    {
        startDot = dotManager.selectedDot;
    }

    // ���� ������ ���¿��� endVec���� ����
    public void setEndVec()
    {
        endDot = dotManager.selectedDot;
    }

    // ���� ȭ��ǥ �����
    private void makeVec()
    {
        // ���� ��ġ�� �� ��ġ
        Vector3 startPos = startDot.transform.position;
        Vector3 endPos = endDot.transform.position;

        // �߰� ������ ������ ����
        Vector3 middlePos = (startPos + endPos) / 2f;
        Vector3 dir = (endPos - startPos).normalized;

        // ���� ȸ����
        Quaternion rotation = Quaternion.LookRotation(dir) * Quaternion.Euler(90,0,0);

        // ���� ����(����)
        GameObject body = Instantiate(vecBodyPrefab, middlePos, rotation);

        // ���� ũ�� ����
        float distance = Vector3.Distance(startPos, endPos);
        Vector3 scale = body.transform.localScale;
        scale.y = distance / 2;
        body.transform.localScale = scale;

        // ���� �Ӹ�(ȭ��ǥ) �����
        Vector3 arrowPos = body.transform.GetChild(0).transform.position;
        Quaternion arrowRot = rotation * Quaternion.Euler(90, 0, 0);
        Instantiate(vecHeadPrefab, arrowPos, arrowRot);

        // �ٽ� null�� �ʱ�ȭ
        startDot = null;
        endDot = null;
    }
}

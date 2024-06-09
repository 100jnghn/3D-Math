using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DotController : MonoBehaviour
{
    public string dotName;                  // ���� �̸�
    public TextMeshProUGUI positionText;    // UI�� �� �ؽ�Ʈ: A(0,0,0)


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // ���� �̸� ����
    public void setName(string dotName)
    {
        this.dotName = dotName;
    }

    // ����� input���� position �Է¹���. z���� ���⼭ ��ȣ ����
    public void setPosition(int x, int y, int z)
    {
        Vector3 pos = new Vector3(x, y, z * -1);
        transform.position = pos;
    }

    // UI�� �� �ؽ�Ʈ ����. A(0,0,0)
    public void setText()
    {
        positionText.text = dotName + "(" + transform.position.x + transform.position.y + transform.position.z * -1 + ")";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DotController : MonoBehaviour
{
    public string dotName;                  // 점의 이름
    public TextMeshProUGUI positionText;    // UI에 들어갈 텍스트: A(0,0,0)


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // 점의 이름 설정
    public void setName(string dotName)
    {
        this.dotName = dotName;
    }

    // 사용자 input으로 position 입력받음. z값은 여기서 부호 반전
    public void setPosition(int x, int y, int z)
    {
        Vector3 pos = new Vector3(x, y, z * -1);
        transform.position = pos;
    }

    // UI에 들어갈 텍스트 설정. A(0,0,0)
    public void setText()
    {
        positionText.text = dotName + "(" + transform.position.x + transform.position.y + transform.position.z * -1 + ")";
    }
}

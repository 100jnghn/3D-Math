using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DotManager : MonoBehaviour
{
    public GameObject dotPrefab;
    public GameObject addPointButton;
    public GameObject pointInputPanel;

    public TMP_InputField nameInputField;
    public TMP_InputField xInputField;
    public TMP_InputField yInputField;
    public TMP_InputField zInputField;

    [HideInInspector]
    public GameObject selectedDot;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // Add Point ��ư ������ �� -> ������ dot ����, UI ����
    public void createDot()
    {
        changeUI();
        selectedDot = Instantiate(dotPrefab, transform.position, dotPrefab.transform.rotation);
    }

    public void changeUI()
    {
        addPointButton.SetActive(false);
        pointInputPanel.SetActive(true);
    }

    // Input Point ��ư ������ �� -> �� �̸� & pos �̵�
    public void inputDot()
    {
        // �̸�, ��ǥ�� null�� �ƴ϶��
        if (nameInputField != null && xInputField!= null &&yInputField!=null && zInputField!=null   )
        {
            string name = nameInputField.text;
            float x = Mathf.Round(Convert.ToSingle(xInputField.text) * 10f) / 10f;
            float y = Mathf.Round(Convert.ToSingle(yInputField.text) * 10f) / 10f;
            float z = Mathf.Round(Convert.ToSingle(zInputField.text) * 10f) / 10f;

            selectedDot.GetComponent<DotController>().setName(name);
            selectedDot.GetComponent<DotController>().setPosition(x, y, z);
            selectedDot.GetComponent<DotController>().setText();

            // UI �ʱ�ȭ
            resetUI();

            // ���õ� �� �ʱ�ȭ
            selectedDot = null;
        } 
    }

    private void resetUI()
    {
        nameInputField.text = "";
        xInputField.text = "";
        yInputField.text = "";
        zInputField.text = "";

        addPointButton.SetActive(true);
        pointInputPanel.SetActive(false);
    }
}

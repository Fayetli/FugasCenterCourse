using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartMethods : MonoBehaviour
{
    //https://docs.unity3d.com/Manual/ExecutionOrder.html

    // ����������� ����� Start ������� ���� ���� �� ��'��� �������������
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // ����������� ����� ���������� ������� ������
    void Start()
    {
        print("Start");
    }

    // ����������� 1 ��� �� ��������� ������� ������
    void Update()
    {
        //Debug.Log("Updade");
    }

    // ����������� 50 ��� �� �������
    private void FixedUpdate()
    {
        //Debug.Log("FixedUpdate");
    }

    // ����������� ���� ������� Update
    private void LateUpdate()
    {
        //Debug.Log("LateUpdate");
    }

    // ����������� ��� ������� ��'����
    private void OnDestroy()
    {
        //Debug.Log("OnDestroy");
    }

    // ����������� ��� �������� ��'����
    private void OnEnable()
    {
        //Debug.Log("OnEnable");
    }

    // ����������� ��� ��������� ��'����
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
}

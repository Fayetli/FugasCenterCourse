using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartMethods : MonoBehaviour
{
    //https://docs.unity3d.com/Manual/ExecutionOrder.html

    // Викликається перед Start мутодом після того як об'єкт зініціалізувався
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // Викликається перед оновленням першого фрейму
    void Start()
    {
        print("Start");
    }

    // Викликається 1 раз на оновлення кожного фрейму
    void Update()
    {
        //Debug.Log("Updade");
    }

    // Викликається 50 раз за секунду
    private void FixedUpdate()
    {
        //Debug.Log("FixedUpdate");
    }

    // Викликається після кожного Update
    private void LateUpdate()
    {
        //Debug.Log("LateUpdate");
    }

    // Викликається при знищенні об'єкта
    private void OnDestroy()
    {
        //Debug.Log("OnDestroy");
    }

    // Викликається при включенні об'єкта
    private void OnEnable()
    {
        //Debug.Log("OnEnable");
    }

    // Викликається при виключенні об'єкта
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
}

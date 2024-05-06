using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public UnityEvent evento1;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            evento1.Invoke();
        }
    }

    private void OnEnable()
    {
        evento1.AddListener(OnMyEvent);
    }

    private void OnDisable()
    {
        evento1.RemoveListener(OnMyEvent);
    }

    private void OnMyEvent()
    {
        Debug.Log("Evento activado");
    }
}

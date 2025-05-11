using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Pump))]
public class InertValue : MonoBehaviour
{
    private Pump pump;

    

    [SerializeField] private float maxValue = 1f;
    [SerializeField] private float minValue = 0f;

    [SerializeField] private float addAmplitude = 1;

    [SerializeField] private float value;

    private void Start()
    {
        pump = GetComponent<Pump>();
    }
    private void Update()
    {
        if (pump == null) return;
        if(pump.ValveSet.State)
        {
            value += addAmplitude * Time.deltaTime;
        }
        else
        {
            value -= addAmplitude * Time.deltaTime;
        }
        value = Mathf.Clamp(value, minValue, maxValue);
    }
}

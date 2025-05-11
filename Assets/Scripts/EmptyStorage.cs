using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyStorage : Flow_ToCarry
{
    [Range(0.0f, 1.0f)]
    [SerializeField] private float emptyForce;
    private float emptyAmplitude = 1.0f; 

    private WaterLvl waterLvl;

    private void Start()
    {
        waterLvl = transform.root.GetComponent<WaterLvl>();
    }

    private void Update()
    {
        if (waterLvl.IsNeedToEmpty)
        {
            amplitude = emptyForce * emptyAmplitude;
            waterLvl.storage -= amplitude;
        }
        else
        {
            amplitude = 0;
        }
    }

}

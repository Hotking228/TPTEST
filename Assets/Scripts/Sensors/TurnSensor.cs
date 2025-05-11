using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSensor : MonoBehaviour
{
    [SerializeField] private Control [] turnConditions;
    private SensorBase sensor;

    private void Start()
    {
        sensor = GetComponent<SensorBase>();
    }

    private void Update()
    {
        bool on = true;
        for (int i = 0; i < turnConditions.Length; i++)
        {
            if (!turnConditions[i].Condition)
            {
                on = false; 
                break;
            }
        }

        if (on)
        {
            sensor.state = SensorState.Up;
        }
        else
        {
            sensor.state = SensorState.Down;
        }
    }
}

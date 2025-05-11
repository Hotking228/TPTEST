using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public enum SensorState
{
    None,
    Up,
    Down
}

public class SensorBase : MonoBehaviour
{
    [SerializeField] protected float maxOrdinte = 1;
    [SerializeField] protected float minOrdinate = 0;
    [SerializeField] protected AnimationCurve curve;
    private float maxAbscissa = 1;
    private float minAbscissa = 0;
    public SensorState state; // сделать private
    public float value; // сделать private 
    public float Value => value;
    private float targetAbscissa;
    protected float curAbscissa;

    protected virtual void Update()
    {
        ChangeValue();
    }

    protected virtual void ChangeValue()
    {
        switch (state)
        {
            case SensorState.Up:
                targetAbscissa = maxAbscissa;
                break;
            case SensorState.Down:
                targetAbscissa = minAbscissa;
                break;
        }

        if (curAbscissa < targetAbscissa)
        {
            curAbscissa += Time.deltaTime;
        }

        if (curAbscissa > targetAbscissa)
        {
            curAbscissa -= Time.deltaTime;
        }

        value = curve.Evaluate(curAbscissa) * (maxOrdinte - minOrdinate);
    }

    public void SetState(SensorState _state)
    {
        state = _state;
    }
}

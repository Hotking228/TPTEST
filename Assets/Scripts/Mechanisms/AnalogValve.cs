using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AnalogValve : SensorBase
{
    private Control ctrl;

    private void Start()
    {
        ctrl = GetComponent<Control>();
    }

    protected override void Update()
    {
        base.Update();
    }

    protected override void ChangeValue()
    {
        curAbscissa = (float)ctrl.Value;
        value = curve.Evaluate(curAbscissa) * (maxOrdinte - minOrdinate);
    }
}

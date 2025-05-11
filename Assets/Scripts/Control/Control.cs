using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InputType
{
    Bool,
    Float,
    Double,
    Int
}

public class Control : MonoBehaviour
{
    [SerializeField] private ConnectToOPC opc;
    [SerializeField] private int indexVar;
    [SerializeField] private InputType inputType;
    private bool condition;
    private double value;
    public bool Condition => condition;
    public double Value => value;

    private void LateUpdate()
    {
        bool condition = false;
        double value = 0;
        string str = opc.Str[indexVar];
        if(inputType == InputType.Bool)
        {
             condition = Decoder.Decode<bool>(str);
        }
        if(inputType == InputType.Float)
        {
            value = Decoder.Decode<float>(str);
        }
        this.condition = condition;
        this.value = value;
    }
}

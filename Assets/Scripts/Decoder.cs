using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decoder : MonoBehaviour
{
    private const string False = "False";
    private const string True = "True";

    public static T Decode<T>(string str)
    {
        object value = null;

        if (float.TryParse(str, out float floatValue))
        {
            value = floatValue;
        }

        else if (double.TryParse(str, out double doubleValue))
        {
            value = doubleValue;
        }

        else if(int.TryParse(str, out int intValue))
        {
            value = intValue;
        }

        else if(str == False)
        {
            value = false;
        }

        else if(str == True)
        {
            value = true;
        }

        return (T)value;
    }
}

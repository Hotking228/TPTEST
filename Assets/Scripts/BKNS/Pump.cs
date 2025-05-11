using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pump : MonoBehaviour
{
    public Valve valveSet;
    public Valve ValveSet => valveSet;
    private void OnTriggerStay(Collider other)
    {
        if (valveSet != null) return;
        Valve valve = other.transform.root.GetComponent<Valve>();
        Pump pump = other.transform.root.GetComponent<Pump>();

        Debug.Log(other.name + " " + name);

        if (valve != null)
        {
            valveSet = valve;
            return;
        }

        if (pump != null && pump.ValveSet != null)
        {
            valveSet = pump.ValveSet;
            return;
        }
    }
}

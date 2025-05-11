using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarryScriptAuto : MonoBehaviour
{
    public Flow_ToCarry flow;
    [HideInInspector]public CarryScriptAuto carryScript;

    private void OnTriggerExit(Collider other)
    {
        if (flow != null && other.GetComponent<Flow_ToCarry>() == flow)
        {
            flow = null;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(flow == null)
            flow = other.GetComponent<Flow_ToCarry>();
        if (flow == null &&  other.GetComponent<CarryScriptAuto>() != null)
        {
            flow = other.GetComponent<CarryScriptAuto>().flow;
        }
    }

}

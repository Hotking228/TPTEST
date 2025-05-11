using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour
{
    public bool state;
    public bool State => state;

    public void OpenValve()
    {
        state = true;
    }

    public void CloseValve()
    {
        state = false;
    }

    public void ChangeState()
    {
        state = !state;
    }
}

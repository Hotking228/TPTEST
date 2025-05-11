using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mech1Btn : MonoBehaviour
{
    private bool timerPerm;
    private float tmr;
    private bool err;
    private const float onRPM = 100;
    private const float changeStateTime = 5;

    public void Reset()
    {
        err = false;
    }

    public bool Work(bool cmd, bool clsLS, bool opnLS, bool err, float rpm, bool isPLCControl)
    {
        bool outCmd = false;
        if (err) return outCmd;

        if (isPLCControl)
        {
            outCmd = cmd;
        }
        else
        {
            outCmd = rpm > onRPM;
        }

        ChangeTimer(cmd, clsLS, opnLS);

        return outCmd;
    }

    private void ChangeTimer(bool cmd, bool clsLS, bool opnLS)
    {
        timerPerm = cmd && !opnLS || !cmd && !clsLS;
    }

    private void Update()
    {
        if (timerPerm)
        {
            tmr += Time.deltaTime;
            if (tmr > changeStateTime)
            {
                err = true;
            }
        }
        else
        {
            tmr = 0;
        }
    }
}

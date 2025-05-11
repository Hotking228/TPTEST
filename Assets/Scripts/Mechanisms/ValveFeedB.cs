using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValveFeedB : SensorBase
{
    public bool feedB; // сделать private
    public bool FeedB => feedB;
    private const float changeStateVal = 0.8f;

    protected override void Update()
    {
        base.Update();

        if (value > changeStateVal)
        {
            feedB = true;
        }
        else
        {
            feedB = false;
        }
    }
}

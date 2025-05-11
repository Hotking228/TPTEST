using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Flow : Flow_ToCarry
{
    
    public TextMeshPro pressureText;
    float t;
    public float omega;
    public float A;
    // Start is called before the first frame update
    void Start()
    {
        amplitude = 0;
        t = 0;
        omega = 1;
        A = 1;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        amplitude = Mathf.Abs( A * Mathf.Sin(t * omega));
        if (t >= Mathf.PI * 2)
            t = 0;

        pressureText.text = (Mathf.Abs(amplitude * 100)).ToString("0.00") + "%";
    }
}

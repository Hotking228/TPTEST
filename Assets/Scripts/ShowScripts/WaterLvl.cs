using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaterLvl : MonoBehaviour
{
  
    public TextMeshPro waterLvlText;
    public Flow_ToCarry flow;

    [HideInInspector]public float storage;
    [SerializeField]private float maxStorage;
    [SerializeField] private bool isEmptyble;
    private bool isNeedToEmpty;

    public bool IsNeedToEmpty
    {
        get { return isNeedToEmpty; }
        set { isNeedToEmpty = value; }
    }


    // Start is called before the first frame update
    void Start()
    {
        isNeedToEmpty = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (flow != null)
        {
          
            storage += flow.amplitude;
            waterLvlText.text = (Mathf.Abs(storage / maxStorage * 100)).ToString("0.00") + "%";
        }
        else

            waterLvlText.text = 0.ToString("0.00") + "%";


        ChangeEmptyMode();

    }

    private void OnTriggerStay(Collider other)
    {
        if (flow != null) return;
        CarryScriptAuto carryScript = other.GetComponent<CarryScriptAuto>();

        if (carryScript != null)
        {
            flow = carryScript.flow;
        }
    }


    private void ChangeEmptyMode()
    {
        if(storage / maxStorage >= 0.8)
            isNeedToEmpty = true;
        if(storage / maxStorage <= 0.1)
            isNeedToEmpty = false;
    }


}

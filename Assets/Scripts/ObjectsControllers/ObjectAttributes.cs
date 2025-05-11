using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAttributes : MonoBehaviour
{
    [SerializeField] private UISelectObjBuilder uiSelect;
    public float height;

    public ObjectType type;



    public void SetObject()
    {
        if (uiSelect != null)
        {
            uiSelect.SetObject(type);
        }
    }
}

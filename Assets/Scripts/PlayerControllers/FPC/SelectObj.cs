using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObj : MonoBehaviour
{
    public GameObject separator;
    public GameObject separatorAlphaMin;
    public GameObject pump;
    public GameObject pumpAlphaMin;

    public GameObject pipe;
    public GameObject pipeAlphaMin;

    public GameObject pipeCurved;
    public GameObject pipeCurvedAlphaMin;



    public SpawnObjects spawnObjects;

   


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeSelectedObj(separator, separatorAlphaMin);

            ShowTransparentObject();
            HideObject(pumpAlphaMin);
            HideObject(pipeAlphaMin);
            HideObject(pipeCurvedAlphaMin);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeSelectedObj(pump, pumpAlphaMin);

            ShowTransparentObject();
            HideObject(separatorAlphaMin);
            HideObject(pipeAlphaMin);
            HideObject(pipeCurvedAlphaMin);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangeSelectedObj(pipe, pipeAlphaMin);
            ShowTransparentObject();
            HideObject(separatorAlphaMin);
            HideObject(pumpAlphaMin);
            HideObject(pipeCurvedAlphaMin);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ChangeSelectedObj(pipeCurved, pipeCurvedAlphaMin);
            ShowTransparentObject();
            HideObject(separatorAlphaMin);
            HideObject(pumpAlphaMin);
            HideObject(pipeAlphaMin);
        }
    }


    private void ChangeSelectedObj(GameObject obj, GameObject alphaMinObj)
    {
        spawnObjects.selectedTransparent = alphaMinObj;
        spawnObjects.selectedObj = obj;
        
    }

    private void ShowTransparentObject()
    {
        if (spawnObjects.showSelected)
        {
            spawnObjects.selectedTransparent.SetActive(true);
        }
    }

    private void HideObject(GameObject obj)
    {
        obj.SetActive(false);
    }

    

}

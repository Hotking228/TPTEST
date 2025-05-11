using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



public enum ObjectType
{
    separator,
    pipe,
    pipeCurved,
    pump
}

public class UISelectObj : MonoBehaviour
{/*
    [SerializeField] private SpawnObjects spawnObjects;
    [SerializeField] private GameObject pipe;
    [SerializeField] private GameObject separator;
    [SerializeField] private GameObject pump;
    [SerializeField] private GameObject pipeCurved;

    [SerializeField] private GameObject pipeAlphaMin;
    [SerializeField] private GameObject separatorAlphaMin;
    [SerializeField] private GameObject pumpAlphaMin;
    [SerializeField] private GameObject pipeCurvedAlphaMin;
    [SerializeField] private FirstPersonController fpc;
    private GameObject currentObject;
    private GameObject currentAlphaMinObject;
    [SerializeField] private GameObject SelectObjectPanel;
    private bool isSelectMenu = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
                PauseGame();
        }
    }


    private void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SelectObjectPanel.SetActive(true);
        fpc.enabled = false;
    }

    public void ContinueGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SelectObjectPanel.SetActive(false);
        fpc.enabled = true;
    }

    private void SetCurrentObject(SelectObjectType type)
    {
        switch (type)
        {
            case SelectObjectType.separator:
                currentObject = separator;
                currentAlphaMinObject = separatorAlphaMin;
                break;

            case SelectObjectType.pipe:
                currentObject = pipe;
                currentAlphaMinObject = pipeAlphaMin;
                break;

            case SelectObjectType.pump:
                currentObject = pump;
                currentAlphaMinObject = pumpAlphaMin;
                break;

            case SelectObjectType.pipeCurved:
                currentObject = pipeCurved;
                currentAlphaMinObject = pipeCurvedAlphaMin;
                break;
        }
    }

    public void SetObject(int type)
    {

        spawnObjects.selectedTransparent.SetActive(false);
        SetCurrentObject((SelectObjectType)type);
        ChangeSelectedObj(currentObject, currentAlphaMinObject);

        ShowTransparentObject();
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
*/
    
}

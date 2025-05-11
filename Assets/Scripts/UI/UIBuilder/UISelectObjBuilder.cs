using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class UISelectObjBuilder : MonoBehaviour
{
    [SerializeField] private SpawnObjects spawnObjects;
    [SerializeField] private GameObject selectPanel;
    [Header("Objects")] 
    [SerializeField] private List<GameObject> elements;
    [SerializeField] private List<GameObject> elementsTransparent;

    public void SetObject(ObjectType objectType)
    {
        spawnObjects.selectedTransparent.SetActive(false);
        spawnObjects.selectedTransparent = elementsTransparent[(int)objectType];
        spawnObjects.selectedObj = elements[(int)objectType];
        spawnObjects.selectedTransparent.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            selectPanel.active = !selectPanel.active;
        }
    }


}

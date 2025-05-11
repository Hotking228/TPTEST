using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject selectedObj;
    public GameObject selectedTransparent;
    public bool showSelected = false;
    
    public Material pipeMaterial;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.V) && !showSelected)
        {
            selectedTransparent.SetActive(true);
            showSelected = true;
        }
        if (Input.GetKey(KeyCode.Q) && showSelected)
        {
            showSelected = false;
            selectedTransparent.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E) && showSelected)
        {

            Vector3 pos = selectedTransparent.transform.position;
            Quaternion rot = selectedTransparent.transform.rotation;


            PipeSetMaterial pipeMaterial =  Instantiate(selectedObj, pos, rot).GetComponent<PipeSetMaterial>();

            
            if (pipeMaterial != null)
            {
                pipeMaterial.rendererView.material = this.pipeMaterial;
            }


           


        }

    }
}

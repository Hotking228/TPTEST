using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSetMaterial : MonoBehaviour
{
    public Renderer rendererView;
    private Material material;
    public bool isMaterialSet;
    private float timer = 0;
    private float timeToSet = 0.5f;

    private void Start()
    {
        isMaterialSet = false;
        if(rendererView == null)
            rendererView = GetComponent<Renderer>();
        material = rendererView.material;

    }

    private void Update()
    {
        if (!isMaterialSet)
        {
            timer += Time.deltaTime;
            if (timer >= timeToSet)
            {
                isMaterialSet = true;
            }
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (!isMaterialSet)
        {
            PipeSetMaterial pipeMaterial = other.transform.root.GetComponent<PipeSetMaterial>();
            WaterLvl waterLvl = other.transform.root.GetComponent<WaterLvl>();
            
            if (pipeMaterial != null && waterLvl == null)
            {
                Renderer otherRenderer = pipeMaterial.GetComponent<PipeSetMaterial>().rendererView;
                if (otherRenderer.material.color!= material.color)
                {
                    material.color = otherRenderer.material.color;
                    isMaterialSet = true;
                }
            }
        }
    }

}

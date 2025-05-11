using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISelectPipeMaterial : MonoBehaviour
{
    private SpawnObjects spawnObjects;

    private void Start()
    {
        spawnObjects = FindObjectOfType<SpawnObjects>();
    }

    public void SetPipeMaterial(Material material)
    {
        spawnObjects.pipeMaterial = material;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpawnObjects))]
public class PlayerBuilderController : MonoBehaviour
{
    [SerializeField] private PlayerBuilder player;
    private SpawnObjects spawnObjects;
    private float cameraHeght;
    private float objectAngle;
    
    

    private void Start()
    {
        objectAngle = 0;
        spawnObjects = GetComponent<SpawnObjects>();
    }

    void Update()
    {
        player.Move();
        if(spawnObjects.showSelected)
        spawnObjects.selectedTransparent.transform.position = GetObjectPosition();

        if (Input.GetKeyDown(KeyCode.R))
        {
            objectAngle += 90f;
        }

        spawnObjects.selectedTransparent.transform.rotation = Quaternion.Euler(spawnObjects.selectedTransparent.transform.rotation.x, objectAngle, spawnObjects.selectedTransparent.transform.rotation.z);

    }


    private Vector3 GetObjectPosition()
    {
        cameraHeght = transform.position.y;

        float x = player.GetMousePosition().x;
        float y = player.GetMousePosition().y;
        float z = player.GetMousePosition().z;

        return new Vector3(x,spawnObjects.selectedTransparent.GetComponent<ObjectAttributes>().height, z);
    }
}

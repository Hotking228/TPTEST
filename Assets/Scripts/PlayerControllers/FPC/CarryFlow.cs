using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryFlow : MonoBehaviour
{
    [SerializeField] private new Camera camera;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            RaycastHit hit;
            if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, 10))
            {
                Valve valve = hit.collider.transform.root.GetComponent<Valve>();
                if ( valve != null)
                {
                    valve.ChangeState();
                }
            }

        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerMode : MonoBehaviour
{
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    //private bool isBuilder = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (player1.active)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                player1.SetActive(false);
                player2.SetActive(true);
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                player2.SetActive(false);
                player1.SetActive(true);
            }
        }
    }
}

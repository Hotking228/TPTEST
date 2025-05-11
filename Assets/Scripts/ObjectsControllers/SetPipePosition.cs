using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SetPipePosition : MonoBehaviour
{

    private string PointTag = "PipePoint";
    private string PointCurvedTag = "PipeCurvedPoint";
    [SerializeField] private FirstPersonController controller;

    private Vector3 startPosition;
    private Quaternion startRotation;

    private RotateCurvedPipe curved;
    private float curvedAngle = 90f;
    private Quaternion defaulAngleCurved;

    private void Start()
    {
        curved = GetComponent<RotateCurvedPipe>();
        startPosition = transform.localPosition;
        startRotation = transform.localRotation;
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.GetMouseButtonDown(1))
            {
                curvedAngle += 180;
                if (curvedAngle >= 360)
                {
                    curvedAngle = 0;
                }
                //  transform.rotation = Quaternion.Euler(new Vector3(90, curvedAngle - defaulAngleCurved.y, 0));
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        
        if (tag != "PipeCurved" && other.tag == PointTag && Input.GetMouseButton(0))
        {

            transform.position = other.transform.position;
            //Debug.Log(transform.position);
           // transform.position = controller.transform.InverseTransformPoint(transform.position);
           transform.rotation = other.transform.GetComponent<Transform>().rotation;
        }
        if (tag == "PipeCurved" && other.tag == PointCurvedTag && Input.GetMouseButton(0))
        {
            transform.position = other.transform.position;

            transform.rotation = Quaternion.Euler(other.transform.eulerAngles.x + curvedAngle, other.transform.eulerAngles.y, other.transform.rotation.z + curvedAngle);

            
           
            //transform.localRotation = Quaternion.Euler(new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y e, transform.localEulerAngles.z));
        }


    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == PointTag)
        {
            transform.localRotation = startRotation;

            transform.localPosition = startPosition;
        }
    }


   

}

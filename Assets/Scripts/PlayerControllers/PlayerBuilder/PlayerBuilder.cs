using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBuilder : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Camera builderCamera;
    

    public void Move()
    {
        Vector3 velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            velocity += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity += new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity += new Vector3(1, 0, 0);
        }
        
        velocity = ClampVelocity(velocity);

        transform.position += velocity * speed * Time.deltaTime;
    }


    private Vector3 ClampVelocity(Vector3 velocity)
    {
        float sqr = velocity.x * velocity.x + velocity.y * velocity.y + velocity.z * velocity.z;

        if(sqr != 0)
            velocity /= sqr;
        return velocity;

    }


    private Vector3 RoundVector3(Vector3 vector)
    {
        return new Vector3(Mathf.Round(vector.x), Mathf.Round(vector.y), Mathf.Round(vector.z));
    }


    public Vector3 GetMousePosition()
    {
        Vector3 mousePos = builderCamera.ScreenToWorldPoint(Input.mousePosition);

        
        return RoundVector3(mousePos);
    }

}

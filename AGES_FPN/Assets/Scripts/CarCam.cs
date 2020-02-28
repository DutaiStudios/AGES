using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCam : MonoBehaviour
{
        Vector2 rotation = new Vector2(0, 0);
        public float speed = 3;
        [SerializeField] int minY;
        [SerializeField] int maxY;
        [SerializeField] int minX;
        [SerializeField] int maxX;  


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
            rotation.y += Input.GetAxis("Mouse X");
            rotation.x += -Input.GetAxis("Mouse Y");
            transform.eulerAngles = (Vector2)rotation * speed;
            restraints();
       
    }

    void restraints()
    {
        if (rotation.y >= maxY)
        {
            rotation.y--;
        }

        if (rotation.y <= minY)
        {
            rotation.y++;
        }

        if (rotation.x >= maxY)
        {
            rotation.x--;
        }

        if (rotation.x <= minY)
        {
            rotation.x++;
        }
    }
    

}

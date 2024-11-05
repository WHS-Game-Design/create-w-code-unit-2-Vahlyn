using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10; 

    public GameObject projectilePrefab;

    void Start()
    {
        
    }

    void Update()
    {
       //Projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        //Negative Axis Stop
        if (transform.position.x < -xRange)
        {
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

       //Positive Axis Stop
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position. y, transform. position.z);
        }

        //Axis Movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
    
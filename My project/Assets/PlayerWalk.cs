using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    private float axisX;
    private float axisY;
    [SerializeField] int speed;
    private Rigidbody rb;

    private void Update()
    {
        axisX = Input.GetAxis("Horizontal");
        axisY = Input.GetAxis("Vertical");
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        
    }
}

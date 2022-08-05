using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    public float maxSpeed;
    public float acceleration;

    [SerializeField]
    private float HorizontalSpeed;
    [SerializeField]
    private float VerticalSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        if (HorizontalSpeed <= maxSpeed)
            HorizontalSpeed += acceleration * Input.GetAxis("Horizontal");

        if (VerticalSpeed <= maxSpeed)
            VerticalSpeed += acceleration * Input.GetAxis("Vertical");

        HorizontalSpeed *= Time.deltaTime;
        VerticalSpeed *= Time.deltaTime;

        transform.Translate( HorizontalSpeed, 0, VerticalSpeed );

    }
}

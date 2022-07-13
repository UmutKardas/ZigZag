using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovementController : MonoBehaviour
{
    [SerializeField] private SphereDataTransmitter sphereDataTransmitter;
    [SerializeField] private Rigidbody rb;

    public float sphereMovementSpeed;



    void FixedUpdate()
    {
        MovementSphereController();
    }



    private void MovementSphereController()
    {
        rb.velocity = sphereDataTransmitter.GetSphereİnputValues() * sphereMovementSpeed * Time.fixedDeltaTime;


    }
}

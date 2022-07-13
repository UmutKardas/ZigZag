using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDataTransmitter : MonoBehaviour
{
    [SerializeField] private SphereİnputController sphereİnputController;


    public Vector3 GetSphereİnputValues()
    {
        return sphereİnputController.direction;
    }




}

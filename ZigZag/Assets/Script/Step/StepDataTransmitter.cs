using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepDataTransmitter : MonoBehaviour
{
    [SerializeField] private StepCollisionController stepCollisionController;
    [SerializeField] private StepCreateController stepCreateController;


    public void CreateNewStepObject()
    {
        stepCreateController.CreateNewStepObject();
    }

}

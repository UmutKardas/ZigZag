using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepCreateController : MonoBehaviour
{
    [SerializeField] private GameObject prefabStep;

    [ContextMenu("Create New Step")]
    private void Start()
    {
        for (int i = 0; i < 75; i++)
        {
            CreateNewStepObject();
        }

    }



    public void CreateNewStepObject()
    {
        if (Random.Range(0, 2) == 0)
        {
            prefabStep = Instantiate(prefabStep, prefabStep.transform.position + Vector3.right, transform.rotation);
        }
        else
        {
            prefabStep = Instantiate(prefabStep, prefabStep.transform.position + Vector3.forward, transform.rotation);
        }
    }

}

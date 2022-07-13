using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KardasGames;

public class StepCollisionController : MonoBehaviour
{
    [SerializeField] private StepDataTransmitter stepDataTransmitter;

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag(Tag.PLAYER))
        {
            stepDataTransmitter.CreateNewStepObject();
            StartCoroutine(AddStepRigidbody());
        }
    }



    IEnumerator AddStepRigidbody()
    {
        yield return new WaitForSeconds(0.75f);
        gameObject.AddComponent<Rigidbody>();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KardasGames;

public class GroundController : MonoBehaviour
{
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag(Tag.PLAYER))
        {
            StartCoroutine(AddStepRigidbody());
        }
    }



    IEnumerator AddStepRigidbody()
    {
        yield return new WaitForSeconds(0.75f);
        gameObject.AddComponent<Rigidbody>();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    [SerializeField] private Transform ballTransform;
    private Vector3 offset;
    [SerializeField] private float lerpValue;
    private Vector3 newPos;

    void Start()
    {
        offset = transform.position - ballTransform.position;
    }

    void LateUpdate()
    {
        newPos = Vector3.Lerp(transform.position, ballTransform.position + offset, lerpValue * Time.deltaTime);
        transform.position = newPos;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere─░nputController : MonoBehaviour
{
    public Vector3 direction;

    private void Start()
    {
        direction = Vector3.forward;
    }


    void Update()
    {
        ─░nputShereController();
    }


    private void ─░nputShereController()
    {


        if (Input.GetMouseButtonDown(0))
        {
            if (direction.z == 1)
            {
                direction = Vector3.right;
            }
            else
            {
                direction = Vector3.forward;
            }
        }



    }
}

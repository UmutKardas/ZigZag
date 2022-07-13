using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereFallController : MonoBehaviour
{
    void Update()
    {
        GetSphereFall();
    }

    private void GetSphereFall()
    {
        if (transform.position.y < -0.2f)
        {
            SceneManager.LoadScene(0);
        }
    }
}

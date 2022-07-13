using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepColorController : MonoBehaviour
{
    [SerializeField] private Material stepMaterial;

    [SerializeField] private Color[] materialColors;
    [SerializeField] private int colorIndex = 0;
    [SerializeField] private float colorLerp;


    [SerializeField] private float time = 2;
    private float currentTime;


    private void Update()
    {
        ChangeSmoothMaterialColor();
    }


    private void OnDestroy()
    {
        stepMaterial.color = materialColors[1];
    }


    private void ChangeSmoothMaterialColor()
    {
        stepMaterial.color = Color.Lerp(stepMaterial.color, materialColors[colorIndex], colorLerp * Time.deltaTime);


        if (currentTime <= 0)
        {
            colorIndex++;
            currentTime = time;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }

        if (colorIndex >= materialColors.Length)
        {
            colorIndex = 0;
        }
    }
}

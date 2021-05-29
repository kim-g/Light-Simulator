using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Объёдиняет группу прожекторов в линию
/// </summary>
public class LightLine : MonoBehaviour
{
    public List<Light> Lights;
    public int Intensity = 0;
    public float Max = 1;
    private int PastIntensity = -1;
    public int CommutationInt = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Intensity != PastIntensity)
        {
            foreach (Light Spot in Lights)
                Spot.intensity = Max * Intensity / 100;
            PastIntensity = Intensity;
        }
    }

    public void Set(int Value)
    {
        CommutationInt = Value > CommutationInt ? Value : CommutationInt;
    }

    public void Commutate()
    {
        Intensity = CommutationInt;
        CommutationInt = 0;
    }
}

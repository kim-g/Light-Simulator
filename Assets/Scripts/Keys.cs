using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    public List<Light> LightList;
    public bool On = false;
    private bool PrevOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PrevOn == On) return;
        PrevOn = On;
        foreach (Light CurrentLight in LightList)
        {
            CurrentLight.intensity = On ? 1 : 0;
        }

    }
}

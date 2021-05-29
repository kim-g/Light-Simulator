using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChannelScript : MonoBehaviour
{
    private int intensity = 0;
    private int old_intensity = 100;

    public List<LightLine> Lines;
    public int Intensity
    {
        get => intensity;
        set
        {
            intensity = value;
            if (intensity > 0) old_intensity = intensity;
        }
    }

    public bool On
    {
        get => intensity > 0;
        set => intensity = value ? old_intensity : intensity = 0;
    }

    public void UpdateLines()
    {
        foreach (LightLine Line in Lines)
            Line.Set(Intensity);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

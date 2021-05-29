using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCommutator : MonoBehaviour
{
    public List<LightLine> Channel_01;
    public List<LightLine> Channel_02;
    public List<LightLine> Channel_03;
    public List<LightLine> Channel_04;
    public List<LightLine> Channel_05;
    public List<LightLine> Channel_06;
    public List<LightLine> Channel_07;
    public List<LightLine> Channel_08;
    public List<LightLine> Channel_09;
    public List<LightLine> Channel_10;
    public List<LightLine> Channel_11;
    public List<LightLine> Channel_12;
    public List<LightLine> Channel_13;
    public List<LightLine> Channel_14;
    public List<LightLine> Channel_15;
    public List<LightLine> Channel_16;
    public List<LightLine> Channel_17;
    public List<LightLine> Channel_18;
    public List<LightLine> Channel_19;
    public List<LightLine> Channel_20;

    public bool On_01 = false;
    public bool On_02 = false;
    public bool On_03 = false;
    public bool On_04 = false;
    public bool On_05 = false;
    public bool On_06 = false;
    public bool On_07 = false;
    public bool On_08 = false;
    public bool On_09 = false;
    public bool On_10 = false;
    public bool On_11 = false;
    public bool On_12 = false;
    public bool On_13 = false;
    public bool On_14 = false;
    public bool On_15 = false;
    public bool On_16 = false;
    public bool On_17 = false;
    public bool On_18 = false;
    public bool On_19 = false;
    public bool On_20 = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (LightLine Line in Channel_01)
            Line.Set(On_01 ? 100 : 0);
        foreach (LightLine Line in Channel_02)
            Line.Set(On_02 ? 100 : 0);
        foreach (LightLine Line in Channel_03)
            Line.Set(On_03 ? 100 : 0);
        foreach (LightLine Line in Channel_04)
            Line.Set(On_04 ? 100 : 0);
        foreach (LightLine Line in Channel_05)
            Line.Set(On_05 ? 100 : 0);
        foreach (LightLine Line in Channel_06)
            Line.Set(On_06 ? 100 : 0);
        foreach (LightLine Line in Channel_07)
            Line.Set(On_07 ? 100 : 0);
        foreach (LightLine Line in Channel_08)
            Line.Set(On_08 ? 100 : 0);
        foreach (LightLine Line in Channel_09)
            Line.Set(On_09 ? 100 : 0);
        foreach (LightLine Line in Channel_10)
            Line.Set(On_10 ? 100 : 0);
        foreach (LightLine Line in Channel_11)
            Line.Set(On_11 ? 100 : 0);
        foreach (LightLine Line in Channel_12)
            Line.Set(On_12 ? 100 : 0);
        foreach (LightLine Line in Channel_13)
            Line.Set(On_13 ? 100 : 0);
        foreach (LightLine Line in Channel_14)
            Line.Set(On_14 ? 100 : 0);
        foreach (LightLine Line in Channel_15)
            Line.Set(On_15 ? 100 : 0);
        foreach (LightLine Line in Channel_16)
            Line.Set(On_16 ? 100 : 0);
        foreach (LightLine Line in Channel_17)
            Line.Set(On_17 ? 100 : 0);
        foreach (LightLine Line in Channel_18)
            Line.Set(On_18 ? 100 : 0);
        foreach (LightLine Line in Channel_19)
            Line.Set(On_19 ? 100 : 0);
        foreach (LightLine Line in Channel_20)
            Line.Set(On_20 ? 100 : 0);

        foreach (LightLine Line in FindObjectsOfType(typeof(LightLine)))
            Line.Commutate();
    }
}

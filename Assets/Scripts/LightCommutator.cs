using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCommutator : MonoBehaviour
{
    public List<Snap> Snaps;
    public byte CurrentSnap = 0;
    public bool[] On = new bool[20] ;
    
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentSnap >= Snaps.Count) return;
        Snaps[CurrentSnap].UpdateSnap(new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, On);
    }
}

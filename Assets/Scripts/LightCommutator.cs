using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCommutator : MonoBehaviour
{
    public List<ChannelScript> Channels;
    public bool[] On = new bool[20] ;
    
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Channels.Count; i++)
        {
            ChannelScript Channel = Channels[i];
            Channel.On = On[i];
            Channel.UpdateLines();
        }

        foreach (LightLine Line in FindObjectsOfType(typeof(LightLine)))
            Line.Commutate();
    }
}

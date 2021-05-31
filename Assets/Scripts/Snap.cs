using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour
{
    /// <summary>
    /// Список каналов в снапе
    /// </summary>
    public List<ChannelScript> Channels;

    /// <summary>
    /// Обновление прожекторов в соответствии со снапом
    /// </summary>
    public void UpdateSnap(List<int> Intensities, bool[] On)
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnapButton : MonoBehaviour
{
    public GameObject SnapButtomPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        LightCommutator Commutator = FindObjectOfType<LightCommutator>();
        GameObject UI = GameObject.Find("UI");


        for (int i=0; i < Commutator.Snaps.Count; i++)
        {
            GameObject NewButton = Instantiate(SnapButtomPrefab, new Vector3(70 + 100*i, 30), new Quaternion(0,0,0,0), this.transform);
            NewButton.GetComponentInChildren<Text>().text = "Снап " + (i+1).ToString();
            NewButton. = i.ToString();
            ((Button)(NewButton.GetComponent<Button>())).onClick.AddListener( () => { OnClick(Convert.ToInt32(this.tag)); Console.WriteLine($"Включаем снап {NewButton.tag}");
            });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(int Snap)
    {
        LightCommutator Commutator = FindObjectOfType<LightCommutator>();
        Commutator.CurrentSnap = (byte)Snap;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Serialization;

[Serializable]
public class Props
{
    public List<Prop> GameObjects = new List<Prop>();
}

public class Saver : MonoBehaviour
{
    public string filepath = @"C:\Users\Kristian\Desktop\MSc Dissertation\MScDissertation\RTX_Dissertation\RTX_Dissertation\Props.json";
    //public string filepath = @"C:\Users\Kristian\Desktop\MSc Dissertation\MScDissertation\RTX_Dissertation\RTX_Dissertation\Props.json"; -- TODO:: Uni filepath

    // Start is called before the first frame update
    void Start()
    {
        //Get all children and write json file with them.
        Props props = new Props();

        foreach(PropInfo info in GetComponentsInChildren<PropInfo>())
        {
            props.GameObjects.Add(info.prop);
        }

        using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, false))
        {
            file.WriteLine(JsonUtility.ToJson(props));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

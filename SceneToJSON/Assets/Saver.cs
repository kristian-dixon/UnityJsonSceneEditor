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
    // Start is called before the first frame update
    void Start()
    {
        //Get all children and write json file with them.
        Props props = new Props();

        foreach(PropInfo info in GetComponentsInChildren<PropInfo>())
        {
            props.GameObjects.Add(info.prop);
        }

        Debug.Log(JsonUtility.ToJson(props));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

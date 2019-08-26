using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class Prop
{ 
    public string Name = "";
    public string Mesh = "";
    public List<float> Transform;
    public List<string> HitGroups;


    public MetalData Metal;
    public MatData Material;
    public WorldData WorldData;
}


[Serializable]
public class MetalData
{
    public string ConstantBufferType = "Metal";
    public float Reflectivity = 0.5f;
    public float Scatter = 0;
}


[Serializable]
public class MatData
{
    public string ConstantBufferType = "Material";
    public List<float> MaterialColour;
    public List<float> SpecularColour;
    public float SpecularPower;
}

[Serializable]
public class WorldData
{
    public string ConstantBufferType = "World";
}



public class PropInfo : MonoBehaviour
{
    public Prop prop;

   

    public bool isMetal;
    public bool isMaterial = true;
    public bool isWorld = true;

    private void Awake()
    {
        prop.Name = gameObject.name;

        

        if(!isMetal)
            prop.Metal.ConstantBufferType = "";


        if (!isMaterial)
        {
            prop.Material.ConstantBufferType = "";
        }

        if(!isWorld)
            prop.WorldData.ConstantBufferType = "";
            



        //Ugly but it works
        prop.Transform.Add(transform.localToWorldMatrix.m00);
        prop.Transform.Add(transform.localToWorldMatrix.m01);
        prop.Transform.Add(transform.localToWorldMatrix.m02);
        prop.Transform.Add(transform.localToWorldMatrix.m03);
        prop.Transform.Add(transform.localToWorldMatrix.m10);
        prop.Transform.Add(transform.localToWorldMatrix.m11);
        prop.Transform.Add(transform.localToWorldMatrix.m12);
        prop.Transform.Add(transform.localToWorldMatrix.m13);
        prop.Transform.Add(transform.localToWorldMatrix.m20);
        prop.Transform.Add(transform.localToWorldMatrix.m21);
        prop.Transform.Add(transform.localToWorldMatrix.m22);
        prop.Transform.Add(transform.localToWorldMatrix.m23);
        prop.Transform.Add(transform.localToWorldMatrix.m30);
        prop.Transform.Add(transform.localToWorldMatrix.m31);
        prop.Transform.Add(transform.localToWorldMatrix.m32);
        prop.Transform.Add(transform.localToWorldMatrix.m33);

        string jsonOutput = JsonUtility.ToJson(prop);


        Debug.Log(jsonOutput);

        
    }
}

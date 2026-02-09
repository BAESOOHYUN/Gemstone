using UnityEngine;
using System;
using System.Collections.Generic;

[Serializable]
public class UVFluorescence
{
    [field: SerializeField] public LWFluorescence LW;
    [field: SerializeField] public SWFluorescence SW;
    [field: SerializeField] public string note;
}

[Serializable]
public class LWFluorescence
{
    [field: SerializeField] public List<string> intensity; // "None", "Faint", "Medium", "Strong", "Very Strong"
    [field: SerializeField] public string color; // "Blue", "Orange", null 가능
}

[Serializable]
public class SWFluorescence
{
    [field: SerializeField] public List<string> intensity;
    [field: SerializeField] public string color;
}

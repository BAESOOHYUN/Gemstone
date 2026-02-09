using System;
using System.Collections.Generic;

[Serializable]
public class UVFluorescence
{
    public LWFluorescence LW;
    public SWFluorescence SW;
    public string note;
}

[Serializable]
public class LWFluorescence
{
    public List<string> intensity; // "None", "Faint", "Medium", "Strong", "Very Strong"
    public string color; // "Blue", "Orange", null 가능
}

[Serializable]
public class SWFluorescence
{
    public List<string> intensity;
    public string color;
}

using System;
using System.Collections.Generic;

[Serializable]
public class RefractiveIndex
{
    public float? min;
    public float? max;
    public float? tolerance_min;
    public float? tolerance_max;
    public bool otl;
    public List<string> spot_reading;
    public string note;
}

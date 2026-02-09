using System;

[Serializable]
public class RefractiveIndexSubtype
{
    public string type; // "high", "medium", "low"
    public float min;
    public float max;
    public float tolerance_min;
    public float tolerance_max;
    public bool otl;
}
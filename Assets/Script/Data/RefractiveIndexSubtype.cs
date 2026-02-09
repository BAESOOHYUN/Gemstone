using System;
using UnityEngine;

[Serializable]
public class RefractiveIndexSubtype
{
    [field: SerializeField] public string type; // "high", "medium", "low"
    [field: SerializeField] public float min;
    [field: SerializeField] public float max;
    [field: SerializeField] public bool otl;
    [field: SerializeField] public float tolerance_min;
    [field: SerializeField] public float tolerance_max;
}
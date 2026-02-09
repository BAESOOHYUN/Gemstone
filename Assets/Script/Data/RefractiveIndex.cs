using UnityEngine;
using System;

[Serializable]
public class RefractiveIndex
{
    [field: SerializeField] public float min;
    [field: SerializeField] public float max;
    [field: SerializeField] public bool otl;
    [field: SerializeField] public float tolerance_min;
    [field: SerializeField] public float tolerance_max;
}
